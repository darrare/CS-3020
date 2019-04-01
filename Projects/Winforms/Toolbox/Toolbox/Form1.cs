using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoSomethingButton.MouseEnter += (o, e) => ChangeColor(Color.Red);
            DoSomethingButton.MouseLeave += (o, e) => ChangeColor(Color.Blue);
        }

        public void ChangeColor(Color c)
        {
            DoSomethingButton.BackColor = c;
        }

        private void DoSomethingButton_Click(object sender, EventArgs e)
        {
            if (Failsafe.Checked && DateTimePicker.Value < DateTime.Now)
                Environment.Exit(0);

            Random rand = new Random();
            if (!Failsafe.Checked)
            {
                Bitmap b = new Bitmap(PictureBox.Width, PictureBox.Height);
                for(int x = 0; x < PictureBox.Width; x++)
                {
                    for (int y = 0; y < PictureBox.Height; y++)
                    {
                        b.SetPixel(x, y, rand.Next(0, 2) == 0 ? Color.Black : Color.White);
                    }
                }
                PictureBox.Image = b;
            }
        }

        private void SecretCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SecretCodeTextBox.Text == "Quit Program")
                Environment.Exit(0);
        }
    }
}
