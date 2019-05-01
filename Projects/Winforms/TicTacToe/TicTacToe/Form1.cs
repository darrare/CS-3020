using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public enum State { Waiting, Playing }
    public enum Mark { X, O };
    public partial class Form1 : Form
    {
        Button[,] buttons = new Button[3, 3];
        State gameState = State.Waiting;
        Mark mark = Mark.X;

        public Form1()
        {
            InitializeComponent();
            NetworkManager.Instance.form = this;

            buttons[0, 0] = Button00;
            buttons[0, 1] = Button01;
            buttons[0, 2] = Button02;
            buttons[1, 0] = Button10;
            buttons[1, 1] = Button11;
            buttons[1, 2] = Button12;
            buttons[2, 0] = Button20;
            buttons[2, 1] = Button21;
            buttons[2, 2] = Button22;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int x = i;
                    int y = j;
                    buttons[i, j].Click += (o, e) => ButtonClick(x, y);
                }
            }
            AddToMessageBox("Find an opponent to start!", false);
        }

        private void AddToMessageBox(string s, bool isCrossThread = true)
        {
            if (isCrossThread)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    TextBox_Status.Text = s + "\n";
                    TextBox_Status.ScrollToCaret();
                    Update();
                }));
            }
            else
            {
                TextBox_Status.Text = s + "\n";
                TextBox_Status.ScrollToCaret();
                Update();
            }
        }

        public void GameEnd(string result)
        {
            if (result == "D")
            {
                AddToMessageBox("It's a draw!");
            }
            else if (mark.ToString() == result)
            {
                AddToMessageBox("You've won!");
            }
            else
            {
                AddToMessageBox("Opponent beat you!");
            }
            gameState = State.Waiting;
        }

        public void GameStart(Mark m)
        {
            foreach(Button b in buttons)
            {
                b.Text = "";
            }
            mark = m;
            gameState = mark == Mark.X ? State.Playing : State.Waiting;
            AddToMessageBox(mark == Mark.X ? "It is your turn" : "Opponents turn");
        }

        private void ButtonClick(int x, int y)
        {
            if (gameState != State.Waiting && buttons[x,y].Text == "")
            {
                UpdateButton(x, y, mark);
                NetworkManager.Instance.SendButtonClickMessage(x, y);
                CycleTurns(x, y);
            }
        }

        public void OpponentSentButtonClick(int x, int y)
        {
            UpdateButton(x, y, mark == Mark.X ? Mark.O : Mark.X);
            CycleTurns(x, y);
        }

        private void CycleTurns(int x, int y)
        {
            if (gameState == State.Playing)
            {
                gameState = State.Waiting;
                AddToMessageBox("Opponents turn");
            }
            else
            {
                gameState = State.Playing;
                AddToMessageBox("It is your turn");
            }

            //Verify game here
            //check col
            for (int i = 0; i < 3; i++)
            {
                if (buttons[x,i].Text != mark.ToString())
                    break;
                if (i == 3 - 1)
                {
                    NetworkManager.Instance.SendWinMessage(mark.ToString());
                }
            }

            //check row
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i, y].Text != mark.ToString())
                    break;
                if (i == 3 - 1)
                {
                    NetworkManager.Instance.SendWinMessage(mark.ToString());
                }
            }

            //check diag
            if (x == y)
            {
                //we're on a diagonal
                for (int i = 0; i < 3; i++)
                {
                    if (buttons[i, i].Text != mark.ToString())
                        break;
                    if (i == 3 - 1)
                    {
                        NetworkManager.Instance.SendWinMessage(mark.ToString());
                    }
                }
            }

            //check anti diag (thanks rampion)
            if (x + y == 3 - 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (buttons[i, (2 - i)].Text != mark.ToString())
                        break;
                    if (i == 3 - 1)
                    {
                        NetworkManager.Instance.SendWinMessage(mark.ToString());
                    }
                }
            }

            //check draw
            bool isFinished = true;
            foreach(Button b in buttons)
            {
                if (b.Text == "")
                {
                    isFinished = false;
                }
            }
            if (isFinished)
            {
                NetworkManager.Instance.SendWinMessage("D");
            }
        }

        private void UpdateButton(int x, int y, Mark m)
        {
            //Draw new button here
            buttons[x, y].Text = m.ToString();
        }

        private void Button_FindNewOpponent_Click(object sender, EventArgs e)
        {
            Connection c = new Connection();
            c.Show();
        }
    }
}
