using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MessagingApp
{
    public partial class Messenger : Form
    {
        public Messenger()
        {
            InitializeComponent();
            ConnectionScreen cs = new ConnectionScreen();
            cs.Show();
            NetworkManager.Instance.messageReceived += OnMessageReceiveEvent;
            TextBox_Input.KeyDown += (o, e) => TextBox_Input_EnterKeyDown(o, e);
        }

        public void OnMessageReceiveEvent(string message)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                RichTextBox_Main.AppendText("[" + DateTime.Now.ToShortTimeString() + "] ", Color.Red);
                RichTextBox_Main.AppendText("Friend: " + message + "\n", Color.Red);
                RichTextBox_Main.ScrollToCaret();
            }));
        }

        private void TextBox_Input_EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_Send_Click(null, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
                
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            NetworkManager.Instance.SendMessage(TextBox_Input.Text);
            RichTextBox_Main.AppendText("[" + DateTime.Now.ToShortTimeString() + "] ", Color.Blue);
            RichTextBox_Main.AppendText("Me: " + TextBox_Input.Text + "\n", Color.Blue);
            TextBox_Input.Text = "";
            RichTextBox_Main.ScrollToCaret();
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }

}
