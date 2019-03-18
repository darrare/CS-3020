using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Parallelization
{
    public partial class Form1 : Form
    {
        bool isFound = false;
        bool isComplete = false;

        Regex TwoToNineCharAllLowercase = new Regex("^[a-z]{2,9}$");
        Stopwatch timer = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called whenever the "Crack" button is clicked on the form. 
        /// Starts the algorithm after some error checking.
        /// </summary>
        private async void StartButton_Click(object sender, EventArgs e)
        {
            if (!TwoToNineCharAllLowercase.IsMatch(PasswordInput.Text))
            {
                MessageBox.Lines = new string[] { "Password must be 2-9 characters long, only lowercase." };
                return;
            }

            if (timer.IsRunning)
            {
                MessageBox.Lines = new string[] { "Search is already running. Wait until it finishes or restart the program." };
                return;
            }

            MessageBox.Lines = new string[] { "Searching..." };

            timer.Reset(); timer.Start();

            /**************************************************/
            /* THIS LINE STARTS THE ALGORITHM, CHANGE TO CRACKPASSWORDPARALLELIZED TO TEST SECONDARY METHOD */
            await Task.Run(() => CrackPassword(PasswordInput.Text));
            /**************************************************/

            timer.Stop();
            MessageBox.Lines = new string[] { "Password cracked = " + isFound.ToString(), "Time took = " + timer.Elapsed.TotalSeconds };
        }

        /// <summary>
        /// A default, brute force method to finding a password. Horribly optimized.
        /// </summary>
        /// <param name="password">The password we are trying to check for</param>
        public void CrackPassword(string password)
        {
            char[] charPassword = password.ToCharArray();
            for(int length = 2; length < 9; length++)
            {
                char[] brute = new char[length];
                for(int i = 0; i < length; i++)
                {
                    brute[i] = (char)97;
                }
                isFound = false;
                isComplete = false;
                while(!isFound && !isComplete)
                {
                    for(int abc = 97; abc <= 122; abc++)
                    {
                        brute[length - 1] = (char)abc;

                        /**************************************************/
                        /* THIS LINE IS VERY SLOW. USE FOR DEBUGGING, OTHERWISE COMMENT OUT */
                        CurrentlyCheckingLabel.Invoke(new MethodInvoker(delegate () { CurrentlyCheckingLabel.Text = new string(brute); }));
                        /**************************************************/

                        if (IsEqual(brute, charPassword))
                        {
                            isFound = true;
                            break;
                        }
                        else if (abc == 122)
                        {
                            int index = length - 2;
                            while(brute[index] == 122)
                            {
                                brute[index] = (char)97;
                                index--;
                                if (index == -1)
                                {
                                    //Everything is "zzzzz" at this point
                                    isComplete = true;
                                    break;
                                }
                            }
                            if (index != -1)
                            {
                                brute[index]++;
                            }
                        }
                    }
                }
                if (isFound)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Parallelized version of the password cracking algorithm
        /// </summary>
        /// <param name="password">The password we are trying to check for</param>
        public void CrackPasswordParallelized(string password)
        {
            /**************************************************/
            /* YOUR ALGORITHM GOES HERE */
            /**************************************************/
        }

        /// <summary>
        /// Compares two char arrays to see if they are equal by value, not by reference
        /// </summary>
        /// <param name="a">First char array to compare</param>
        /// <param name="b">Second char array to compare</param>
        /// <returns>True if they are equal by value, false otherwise</returns>
        public bool IsEqual(char[] a, char[] b)
        {
            if (a.Length != b.Length)
                return false;

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
