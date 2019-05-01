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


namespace TicTacToe
{
    public partial class Connection : Form
    {
        TcpClient connection;

        public Connection()
        {
            InitializeComponent();
            Label_MyLocalIP.Text = "Local IP: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
            Label_MyPublicIP.Text = "Public IP " + GetPublicIP();
        }

        private string GetPublicIP()
        {
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            return a4;
        }

        private void AddToMessageBox(string s)
        {
            //Must invoke as delegate due to cross thread work
            this.Invoke(new MethodInvoker(delegate
            {
                RichTextBox_Notifications.AppendText(s + "\n");
                RichTextBox_Notifications.ScrollToCaret();
                Update();
            }));
        }

        private async void Button_OpenConnection_Click(object sender, EventArgs e)
        {
            try
            {
                AddToMessageBox("Sending Connection Ping");
                connection = new TcpClient(TextBox_TheirIPAddress.Text, 5555);
                NetworkManager.Instance.Initialize(connection, 1);
            }
            catch (Exception ex)
            {
                AddToMessageBox("No response, opening listener");
                TcpListener listener = new TcpListener(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork), 5555);
                listener.Start();
                connection = await listener.AcceptTcpClientAsync();
                listener.Stop();
                NetworkManager.Instance.Initialize(connection, 0);
            }
            AddToMessageBox("Connection found, Success");
            AddToMessageBox("Enjoy your game!");
            Task t = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);
            });
            t.Wait();
            Close();
        }
    }
}
