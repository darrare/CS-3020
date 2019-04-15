using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctioneerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Host_Click(object sender, EventArgs e)
        {
            HostManager.Instance.Initialize();
        }

        private void Button_Client_Click(object sender, EventArgs e)
        {
            ClientManager.Instance.Initialize();
        }
    }
}
