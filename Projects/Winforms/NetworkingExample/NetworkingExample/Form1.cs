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
/// Only one client needs to start the listener. They are the host.
/// The other client just needs to send pings to test.
/// </summary>
namespace HostClient
{
    public partial class Form1 : Form
    {
        TcpClient connection;
        public Form1()
        {
            InitializeComponent();
            Label_LocalIP.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
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
            connection = await listener.AcceptTcpClientAsync();
            listener.Stop();
            Task.Factory.StartNew(() => ListenForPacket());
        }

        private void Button_SendPing_Click(object sender, EventArgs e)
        {
            if (connection == null)
                connection = new TcpClient(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString(), 5555);

            SendMessage(DateTime.Now.ToLongTimeString());
        }

        private void ListenForPacket()
        {
            NetworkStream stream = connection.GetStream();
            while (true)
            {
                byte[] bytesToRead = new byte[connection.ReceiveBufferSize];
                int bytesRead = stream.Read(bytesToRead, 0, connection.ReceiveBufferSize);
                string result = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                if (result != "")
                {
                    AddToMessageBox(result);
                }
            }
        }

        private void SendMessage(string s)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(s);
            connection.GetStream().Write(bytesToSend, 0, bytesToSend.Length);
        }
    }
}
