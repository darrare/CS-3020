using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Net;

namespace AuctioneerApp
{
    public class TcpClientIdPair
    {
        public TcpClient client;
        public int id;
        public Task task;
    }
    class HostManager
    {
        #region singleton
        static HostManager instance;
        public static HostManager Instance
        {
            get { return instance ?? (instance = new HostManager()); }
        }
        #endregion

        IPAddress address;
        TcpListener listener;

        object ClientListLock = new object();
        List<TcpClientIdPair> clients = new List<TcpClientIdPair>();

        HostForm form;

        object HighestBidLock = new object();
        int highestBid = 0;

        private HostManager()
        {
            form = new HostForm();
            form.Show();
            address = IPAddress.Parse("127.0.0.1");
            listener = new TcpListener(address, 5050);
            Task t = Task.Factory.StartNew(() => ListenForNewConnections());
        }

        public void Initialize()
        {

        }

        void ListenForNewConnections()
        {
            listener.Start();
            while (true)
            {
                lock (ClientListLock)
                {
                    clients.Add(new TcpClientIdPair()
                    {
                        client = listener.AcceptTcpClient(),
                        id = clients.Count > 0 ? clients.Max(t => t.id) + 1 : 0,
                    });
                    clients.Last().task = Task.Factory.StartNew(() => ListenToClient(clients.Last()));

                    for (int i = clients.Count - 1; i >= 0; i--)
                    {
                        try
                        {
                            clients[i].client.GetStream().Write(new byte[clients[i].client.ReceiveBufferSize], 0, clients[i].client.ReceiveBufferSize);
                        }
                        catch
                        {
                            clients[i].task.Dispose();
                            clients.Remove(clients[i]);
                        }
                    }
                    form.UpdateListBox(clients);
                }
            }
        }

        void ListenToClient(TcpClientIdPair client)
        {
            NetworkStream stream = client.client.GetStream();
            try
            {
                while (true)
                {

                    byte[] bytesToRead = new byte[client.client.ReceiveBufferSize];
                    int bytesRead = stream.Read(bytesToRead, 0, client.client.ReceiveBufferSize);
                    string result = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                    if (result != "")
                    {
                        form.UpdateDebuggingText("Bid received " + result + " from client " + client.id);
                        if (int.Parse(result) > highestBid)
                        {
                            lock (HighestBidLock)
                            {
                                highestBid = int.Parse(result);
                                SendBidToClients(result);
                            }
                                
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        void SendBidToClients(string result)
        {
            foreach(var v in clients)
            {
                SendNewBidToClient(v, result);
            }
        }

        void SendNewBidToClient(TcpClientIdPair client, string newBid)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(newBid);
            client.client.GetStream().Write(bytesToSend, 0, bytesToSend.Length);
        }
    }
}