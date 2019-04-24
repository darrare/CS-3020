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
using System.Threading;

namespace Matchmaker
{
    public partial class Form1 : Form
    {
        List<TcpClient> connections = new List<TcpClient>();
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

        private async void Button_StartMatchmaker_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork), 5555);
            listener.Start();
            while(true)
            {
                connections.Add(await listener.AcceptTcpClientAsync());
                if(connections.Count == 2)
                {
                    foreach(TcpClient c in connections)
                    {
                        SendMessage(c, "Match found. Sending match info.");
                    }
                    SendMessage(connections[0], "IP" + ((IPEndPoint)connections[1].Client.RemoteEndPoint).Address.ToString());
                    Thread.Sleep(100);
                    SendMessage(connections[1], "IP" + ((IPEndPoint)connections[0].Client.RemoteEndPoint).Address.ToString());
                    connections.Clear();
                }
                else
                {
                    SendMessage(connections[connections.Count - 1], "Match not available. waiting");
                }
            }            
        }

        private void Button_FindMatch_Click(object sender, EventArgs e)
        {
            if (connection == null)
                connection = new TcpClient(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString(), 5555);

            Task.Factory.StartNew(() => ListenForPacket(connection));
            SendMessage(connection, "Client connected to matchmaker");
        }

        private async void ListenForPacket(TcpClient singleConnection)
        {
            NetworkStream stream = singleConnection.GetStream();
            while (true)
            {
                byte[] bytesToRead = new byte[singleConnection.ReceiveBufferSize];
                int bytesRead = stream.Read(bytesToRead, 0, singleConnection.ReceiveBufferSize);
                string result = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                if (result != "" && result.Substring(0, 2) != "IP")
                {
                    AddToMessageBox(result);
                }
                else if (result.Substring(0, 2) == "IP")
                {
                    string ipAddress = result.Substring(2);
                    try
                    {
                        connection = new TcpClient(ipAddress, 5555);
                    }
                    catch
                    {
                        AddToMessageBox("Waiting for match with listener.");
                        TcpListener listener = new TcpListener(IPAddress.Parse(ipAddress), 5555);
                        listener.Start();
                        connection = await listener.AcceptTcpClientAsync();
                        await Task.Factory.StartNew(() => ListenForPacket(connection));
                        listener.Stop();
                        return;
                    }
                    AddToMessageBox("Found match");
                    await Task.Factory.StartNew(() => ListenForPacket(connection));
                }
            }
        }

        private void SendMessage(TcpClient singleConnection, string s)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(s);
            singleConnection.GetStream().Write(bytesToSend, 0, bytesToSend.Length);
        }

        private void Button_SendPing_Click(object sender, EventArgs e)
        {
            SendMessage(connection, DateTime.Now.ToLongTimeString());
        }
    }
}
