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

/// <summary>
/// First real line in Button_SendPing_Click is where you put their IP Address.
/// I recommend using a textbox for input and just have TextBox.Text there instead.
/// 
/// One host starts the host, and many clients can connect to it. Clients can each ping the host, and the host can simultaneously ping every client.
/// </summary>
namespace HostManyClients
{
    public partial class Form1 : Form
    {
        List<TcpClient> connections = new List<TcpClient>();
        TcpClient connection;

        
        public Form1()
        {
            var myList = new[]
            {
                new { MessageType = "INFO", IP = "127.0.0.1", NickName = "Ryan", Msg = ""},
                new { MessageType = "INFO", IP = "127.0.0.1", NickName = "Bob", Msg = ""},
                new { MessageType = "INFO", IP = "127.0.0.1", NickName = "Sally", Msg = ""},
                new { MessageType = "INFO", IP = "127.0.0.1", NickName = "Jerry", Msg = ""},
                new { MessageType = "INFO", IP = "127.0.0.1", NickName = "Kim", Msg = ""},
            }.ToList();

            SendMessage("CONNECTION", "");
            SendMessage("MESSAGE", "Hi nerds");

            string toSend = JsonConvert.SerializeObject(new NetworkMessage { MessageType = "INFO", IP = "127.0.0.1", NickName = "Ryan", Message = "Hi" });

            InitializeComponent();
            Label_LocalIP.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
        }

        public class NetworkMessage
        {
            public string MessageType { get; set; }
            public string IP { get; set; }
            public string NickName { get; set; }
            public string Message { get; set; }
        }

        public void SendMessage(string messageType, string message)
        {
            string ip = "code to get IP here";
            string nickName = "access some public variable here";

            var anonType = new { MessageType = messageType, IP = ip, NickName = nickName, Msg = message };
        }

        private void AddToMessageBox(string s)
        {
            //Must invoke as delegate due to cross thread work
            this.Invoke(new MethodInvoker(delegate
            {
                RichTextBox_Message.AppendText(s + "\n");
                RichTextBox_Message.ScrollToCaret();
            }));
        }

        private async void Button_StartListener_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork), 5555);
            listener.Start();
            while(true)
            {
                connections.Add(await listener.AcceptTcpClientAsync());
                Task.Factory.StartNew(() => ListenForPacket(connections[connections.Count - 1]));
            }            
        }

        private void Button_SendPing_Click(object sender, EventArgs e)
        {
            if (connections.Count == 0)
            {
                if (connection == null)
                    connection = new TcpClient(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString(), 5555);

                //IMPORTANT
                Task.Factory.StartNew(() => ListenForPacket(connection));
                SendMessage(connection, DateTime.Now.ToLongTimeString());
            }
            else
            {
                foreach (TcpClient c in connections)
                {
                    SendMessage(c, DateTime.Now.ToLongTimeString());
                }
            }
        }

        private void ListenForPacket(TcpClient singleConnection)
        {
            NetworkStream stream = singleConnection.GetStream();
            while (true)
            {
                byte[] bytesToRead = new byte[singleConnection.ReceiveBufferSize];
                int bytesRead = stream.Read(bytesToRead, 0, singleConnection.ReceiveBufferSize);
                string result = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                if (result != "")
                {
                    AddToMessageBox(result);
                }
            }
        }

        private void SendMessage(TcpClient singleConnection, string s)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(s);
            singleConnection.GetStream().Write(bytesToSend, 0, bytesToSend.Length);
        }
    }
}
