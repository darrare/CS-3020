using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace InfiniteCampusInput
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        Dictionary<char, byte> Conversions = new Dictionary<char, byte>()
        {
            {'0', 0x30},
            {'1', 0x31},
            {'2', 0x32},
            {'3', 0x33},
            {'4', 0x34},
            {'5', 0x35},
            {'6', 0x36},
            {'7', 0x37},
            {'8', 0x38},
            {'9', 0x39},
            {'.', 0xBE},
        };

        uint KEY_DOWN_EVENT = 0x0001; //Key down flag
        uint KEY_UP_EVENT = 0x0002; //Key up flag
        byte DOWN_KEY = 0x28;
        byte UP_KEY = 0x26;
        byte RIGHT_KEY = 0x27;

        List<List<string>> result;
        List<List<string>> grades = new List<List<string>>();

        int numColumns = 3;
        int startingColumn = 5;
        int numStudents = 21;
        int delay = 20;

        List<Label> OutputLabelTextBoxes = new List<Label>();
        List<TextBox> OutputColumnTextBoxes = new List<TextBox>();
        List<TextBox> InputRangeTextBoxes = new List<TextBox>();
        List<Label> InputRangeLabelTextBoxes = new List<Label>();

        public Form1()
        {
            InitializeComponent();
            NumColumnsText.Text = numColumns.ToString();
            LatencyDelayText.Text = delay.ToString();
            LoadInput();
        }

        private void SaveInput()
        {
            using (StreamWriter sr = new StreamWriter(Application.StartupPath + "/data.data"))
            {
                sr.WriteLine(NumColumnsText.Text);
                sr.WriteLine(LatencyDelayText.Text);
                StringBuilder sb = new StringBuilder();
                foreach (TextBox b in OutputColumnTextBoxes)
                {
                    sb.Append(b.Text + ",");
                }
                sr.WriteLine(sb.ToString());
                sb.Clear();
                foreach (TextBox b in InputRangeTextBoxes)
                {
                    sb.Append(b.Text + ",");
                }
                sr.WriteLine(sb.ToString());
            }
        }

        private void LoadInput()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + "/data.data"))
                {
                    NumColumnsText.Text = sr.ReadLine();
                    NumColumnsText_TextChanged(null, null);
                    LatencyDelayText.Text = sr.ReadLine();
                    string[] outputData = sr.ReadLine().Split(',');
                    string[] inputRangeData = sr.ReadLine().Split(',');

                    for (int i = 0; i < OutputLabelTextBoxes.Count; i++)
                    {
                        OutputColumnTextBoxes[i].Text = outputData[i];
                        InputRangeTextBoxes[i].Text = inputRangeData[i];
                    }
                }
            }
            catch
            {
                ShowMessage("Unable to load file");
            }
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            SaveInput();
            using (OpenFileDialog o = new OpenFileDialog())
            {
                o.Multiselect = false;
                if (o.ShowDialog() == DialogResult.OK)
                {
                    result = SplitListInto2DStructure(LoadCsvFile(o.FileName));
                    grades.Clear();
                    for (int i = 0; i < numColumns; i++)
                    {
                        grades.Add(new List<string>());
                        try
                        {
                            string[] data = InputRangeTextBoxes[i].Text.Split('-');
                            int column1 = data[0][0].ToString().ToUpper()[0] - 65;
                            int row1 = int.Parse(data[0].Substring(1));
                            int column2 = data[1][0].ToString().ToUpper()[0] - 65;
                            int row2 = int.Parse(data[1].Substring(1));
                            if (column1 != column2)
                                throw new FormatException();

                            ShowMessage("Data successfully loaded.");
                            grades[i] = ConvertColumnToFloatValue(result, column1, row1, row2);
                        }
                        catch (FormatException ex)
                        {
                            ShowMessage("Format incorrect, cannot handle multiple columns.");
                            break;
                        }
                        catch(Exception ex)
                        {
                            ShowMessage("Cannot parse file due to invalid range or CSV file is currently opened in another program.");
                            break;
                        }
                    }
                }
            }
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            if (result != null)
            {
                ShowMessage("Tab into Infinite Campus and put your cursor in the first column, first row. You have 5 seconds.");
                Thread.Sleep(100);
                Thread.Sleep(5000);
                CustomizedLogic(grades);
            }
            else
            {
                ShowMessage("No file has been parsed yet. Please select a file.");
            }
        }

        void CustomizedLogic(List<List<string>> results)
        {
            for (int i = 0; i < OutputColumnTextBoxes.Count; i++)
            {
                int col = 1;
                if (i != 0)
                {
                    col = int.Parse(OutputColumnTextBoxes[i - 1].Text);
                }

                while (col != int.Parse(OutputColumnTextBoxes[i].Text))
                {
                    col++;
                    PressKey(RIGHT_KEY);
                }

                InputColumn(results[i]);
                for (int j = 0; j < results[i].Count; j++)
                {
                    PressKey(UP_KEY);
                }
            }
        }

        /// <summary>
        /// Generates the column data in list-string form
        /// </summary>
        /// <param name="input">The raw csv data (entire file)</param>
        /// <param name="sc">starting column</param>
        /// <param name="sr">starting row</param>
        /// <param name="er">ending row</param>
        List<string> ConvertColumnToFloatValue(List<List<string>> input, int sc, int sr, int er)
        {
            List<string> result = new List<string>();
            for (int i = sr - 1; i < er; i++)
            {
                float r = 0;
                if (float.TryParse(input[i][sc], out r))
                {
                    result.Add(input[i][sc]);
                }
            }
            return result;
        }

        /// <summary>
        /// Reads the entire CSV. Saves as a List of string
        /// </summary>
        List<string> LoadCsvFile(string filePath)
        {
            List<string> result = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(File.OpenRead(filePath)))
                {
                    while (!sr.EndOfStream)
                    {
                        result.Add(sr.ReadLine());
                    }
                }
            }
            catch
            {
                ShowMessage("Can't open file, it is probably already open. Close first.");
            }

            return result;
        }

        /// <summary>
        /// Takes the comma delimited CSV and turns it into a 2d list of strings
        /// </summary>
        List<List<string>> SplitListInto2DStructure(List<string> input)
        {
            List<List<string>> result = new List<List<string>>();
            foreach (string s in input)
            {
                result.Add(new List<string>());
                foreach (string split in s.Split(','))
                {
                    result[result.Count - 1].Add(split);
                }
            }
            return result;
        }

        void InputColumn(List<string> vals)
        {
            foreach (string s in vals)
            {
                InputStringValueToInfiniteCampus(s);
                PressKey(DOWN_KEY);
            }
        }

        void InputStringValueToInfiniteCampus(string floatVal)
        {
            foreach (char c in floatVal)
            {
                PressKey(Conversions[c]);
            }
        }

        void PressKey(byte key)
        {
            keybd_event(key, 0, KEY_DOWN_EVENT, 0);
            Thread.Sleep(delay);
            keybd_event(key, 0, KEY_UP_EVENT, 0);
            Thread.Sleep(delay);
        }

        void ShowMessage(string message)
        {
            MessageBox.Text = message;
        }

        private void NumColumnsText_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(NumColumnsText.Text, out numColumns))
            {
                ShowMessage("Enter an integer value for number of columns.");
            }
            else
            {
                ShowMessage("");

                OutputLabelTextBoxes.Clear();
                OutputColumnTextBoxes.Clear();
                InputRangeTextBoxes.Clear();
                InputRangeLabelTextBoxes.Clear();
                OutputColumnPanel.Controls.Clear();
                InputRangePanel.Controls.Clear();

                for (int i = 0; i < numColumns; i++)
                {
                    Label l = new Label();
                    l.Text = (i + 1).ToString();
                    OutputLabelTextBoxes.Add(l);

                    TextBox t = new TextBox();
                    t.TextChanged += delegate (object s, EventArgs ev)
                    {
                        int dummyInt;
                        if (!int.TryParse(((TextBox)s).Text, out dummyInt))
                        {
                            ShowMessage("Input column must be an integer.");
                        }
                        else
                        {
                            ShowMessage("");
                        }
                    };
                    OutputColumnTextBoxes.Add(t);

                    t = new TextBox();
                    t.TextChanged += delegate (object s, EventArgs ev)
                    {
                        try
                        {
                            string[] data = ((TextBox)s).Text.Split('-');
                            int column1 = data[0][0].ToString().ToUpper()[0] - 65;
                            int row1 = int.Parse(data[0].Substring(1));
                            int column2 = data[1][0].ToString().ToUpper()[0] - 65;
                            int row2 = int.Parse(data[1].Substring(1));
                            ShowMessage("");
                        }
                        catch(Exception ex)
                        {
                            ShowMessage("Must be in proper format." + ex.Message);
                        }

                    };
                    InputRangeTextBoxes.Add(t);

                    l = new Label();
                    l.Text = "Range";
                    InputRangeLabelTextBoxes.Add(l);
                }

                for (int i = 0; i < numColumns; i++)
                {
                    OutputColumnPanel.Controls.Add(OutputColumnTextBoxes[i]);
                    InputRangePanel.Controls.Add(InputRangeTextBoxes[i]);
                }
            }
        }

        private void LatencyDelayText_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(LatencyDelayText.Text, out delay))
            {
                ShowMessage("Enter an integer value for the delay to wait between each action (key press) in milliseconds");
            }
            else
            {
                ShowMessage("");
            }
        }
    }
}
