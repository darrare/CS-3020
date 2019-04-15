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
using System.Net.WebSockets;
using System.Net;

namespace AuctioneerApp
{
    public partial class HostForm : Form
    {
        public HostForm()
        {
            InitializeComponent();
        }

        public void UpdateListBox(List<TcpClientIdPair> clients)
        {
            Host_ClientListBox.Invoke(new MethodInvoker(delegate ()
            {
                Host_ClientListBox.Items.Clear();
                foreach (TcpClientIdPair c in clients)
                {
                    Host_ClientListBox.Items.Add(c.id);
                }
            }));

        }

        public void UpdateDebuggingText(string s)
        {
            Debugging.Invoke(new MethodInvoker(delegate ()
            {
                Debugging.Text = s;
            }));
        }
    }
}
