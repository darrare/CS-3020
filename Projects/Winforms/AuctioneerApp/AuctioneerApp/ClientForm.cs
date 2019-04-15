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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            ClientManager.Instance.SendMessage(Debugging.Text);
        }

        public void ChangeWarningText(string s)
        {
            WarningBox.Text = s;
        }

        public void ChangeValueText(string s)
        {
            ValueLabel.Invoke(new MethodInvoker(delegate ()
            {
                ValueLabel.Text = s;
            }));
        }
    }
}
