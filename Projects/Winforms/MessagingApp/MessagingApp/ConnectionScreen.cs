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
using System.Diagnostics;

namespace MessagingApp
{
    public partial class ConnectionScreen : Form
    {
        int requestTimeoutDelay = 5000; //5 seconds
        Random rand = new Random();
        int port;
        IPAddress ipAddress;
        IPAddress subnetIP;
        public ConnectionScreen()
        {
            port = rand.Next(5000, 6000);
            InitializeComponent();
            ipAddress = IPAddress.Parse(GetPublicIpAddress());
            Label_MyIpAddress.Text = "IP Address: " + ipAddress;
            subnetIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
            Label_MySubnetIP.Text = "Subnet IP: " + subnetIP;
            Label_MyPort.Text = "Port: " + port;
        }

        private string GetPublicIpAddress()
        {
            string url = "http://checkip.dyndns.org";
            WebRequest req = WebRequest.Create(url);
            WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            return a4;
        }

        TcpClient listen;
        TcpClient sender;
        private async void Button_FindConnection_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(subnetIP, port);
            try
            {
                listener.Start();
            }
            catch (Exception ex)
            {
                //Don't let it start another listener if one is already running.
                return;
            }

            Task t = Task.Factory.StartNew(() =>
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                bool foundSomething = false;
                while (sw.ElapsedMilliseconds < requestTimeoutDelay)
                {
                    try
                    {
                        this.sender = new TcpClient(TextBox_TheirIPAddress.Text, int.Parse(TextBox_TheirPort.Text));
                        foundSomething = true;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Thread.Sleep(requestTimeoutDelay / 100);
                    }
                }
                if (foundSomething == false)
                    listener.Stop();
            });

            try
            {
                listen = await listener.AcceptTcpClientAsync();
                if (listen != null)
                {
                    while (this.sender == null)
                    {
                        //Wait
                        Thread.Sleep(100);
                    }
                    NetworkManager.Instance.Initialize(listen, this.sender);
                    listener.Stop();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                listener.Stop();
                MessageBox.Show("Request timed out. IP / Port not found or unable to be connected.", "Message", MessageBoxButtons.OK);
            }
        }
    }
}
