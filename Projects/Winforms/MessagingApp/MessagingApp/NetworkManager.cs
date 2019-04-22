using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp
{
    class NetworkManager
    {
        public TcpClient Listener { get; set; }
        public TcpClient Sender { get; set; }

        static NetworkManager instance;

        public delegate void MessageReceived(string message);
        public MessageReceived messageReceived;

        public static NetworkManager Instance
        {
            get { return instance ?? (instance = new NetworkManager()); }
        }

        private NetworkManager()
        {
            
        }

        private void ListenToClient()
        {
            NetworkStream stream = Listener.GetStream();
            while (true)
            {
                byte[] bytesToRead = new byte[Listener.ReceiveBufferSize];
                int bytesRead = stream.Read(bytesToRead, 0, Listener.ReceiveBufferSize);
                string result = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                if (result != "")
                {
                    messageReceived(result);
                }
            }
        }

        public void SendMessage(string message)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(message);
            Sender.GetStream().Write(bytesToSend, 0, bytesToSend.Length);
        }

        public void Initialize(TcpClient client, TcpClient sender)
        {
            Listener = client;
            Sender = sender;
            Task t = Task.Factory.StartNew(() => ListenToClient());
        }
    }
}
