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
    class ClientManager
    {
        #region singleton
        static ClientManager instance;
        public static ClientManager Instance
        {
            get { return instance ?? (instance = new ClientManager()); }
        }
        #endregion

        TcpClient server;
        ClientForm form;

        private ClientManager()
        {
            form = new ClientForm();
            form.Show();
            server = new TcpClient("10.0.0.66", 5050);
            Task t = Task.Factory.StartNew(() => ListenToServer());
        }

        public void Initialize()
        {

        }

        public void SendMessage(string s)
        {
            int result;
            if (int.TryParse(s, out result))
            {
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(s);
                server.GetStream().Write(bytesToSend, 0, bytesToSend.Length);
            }
            else
            {
                form.ChangeWarningText("Input not an integer");
            }
        }

        void ListenToServer()
        {
            NetworkStream stream = server.GetStream();
            while (true)
            {

                byte[] bytesToRead = new byte[server.ReceiveBufferSize];
                int bytesRead = stream.Read(bytesToRead, 0, server.ReceiveBufferSize);
                string result = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                if (result != "")
                {
                    form.ChangeValueText(result);
                }
            }
        }
    }
}
