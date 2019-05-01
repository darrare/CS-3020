using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace TicTacToe
{
    class NetworkManager
    {
        TcpClient connection;
        public Form1 form;

        static NetworkManager instance;

        public static NetworkManager Instance
        { get { return instance ?? (instance = new NetworkManager()); } }

        private NetworkManager() { }

        public void Initialize(TcpClient connection, int result)
        {
            this.connection = connection;
            Task.Factory.StartNew(() => ListenForPacket());
            form.GameStart(result == 0 ? Mark.X : Mark.O);
        }

        private void ListenForPacket()
        {
            NetworkStream stream = connection.GetStream();
            while (true)
            {
                byte[] bytesToRead = new byte[connection.ReceiveBufferSize];
                int bytesRead = stream.Read(bytesToRead, 0, connection.ReceiveBufferSize);
                string result = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                if (result != "" && result.Length == 3)
                {
                    form.OpponentSentButtonClick(int.Parse(result.Split(',')[0]), int.Parse(result.Split(',')[1]));
                }
                else if (result != "" && result.Length == 1)
                {
                    form.GameEnd(result);
                }
            }
        }

        public void SendButtonClickMessage(int x, int y)
        {
            SendMessage(x + "," + y);
        }

        public void SendWinMessage(string s)
        {
            SendMessage(s);
            form.GameEnd(s);
        }

        private void SendMessage(string s)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(s);
            connection.GetStream().Write(bytesToSend, 0, bytesToSend.Length);
        }
    }
}
