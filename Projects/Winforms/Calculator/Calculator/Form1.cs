using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string leftOperand = "";
        string rightOperand = "";
        string operation = "";
        string result = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            operation = "/";
            ConcatCharacterToOperand("");
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            operation = "*";
            ConcatCharacterToOperand("");
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            operation = "-";
            ConcatCharacterToOperand("");
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            operation = "+";
            ConcatCharacterToOperand("");
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            float left = float.Parse(leftOperand);
            float right = float.Parse(rightOperand);
            switch (operation)
            {
                case "/":
                    result = (left / right).ToString();
                    break;
                case "*":
                    result = (left * right).ToString();
                    break;
                case "-":
                    result = (left - right).ToString();
                    break;
                case "+":
                    result = (left + right).ToString();
                    break;
            }

            TextBoxMain.Lines = new string[] { "", result };
        }

        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand(".");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand("0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ConcatCharacterToOperand("9");
        }

        private void ConcatCharacterToOperand(string value)
        {
            if (operation == "")
            {
                leftOperand += value;
                TextBoxMain.Lines = new string[] { "", leftOperand };
            }
            else
            {
                rightOperand += value;
                TextBoxMain.Lines = new string[] { leftOperand + " " + operation, rightOperand };
            }
        }
    }
}
