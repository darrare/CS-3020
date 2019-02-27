using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        private async void button1_Click(object sender, EventArgs e)
        {
            await ExpensiveOperation();
            textBox1.Text = rand.Next(0, 5000).ToString();
        }

        async Task ExpensiveOperation()
        {
            await Task.Delay(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "ASD";
        }
    }
}
