using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AsyncPeopleManager
{
    /// <summary>
    /// http://eforexcel.com/wp/downloads-18-sample-csv-files-data-sets-for-testing-sales/
    /// </summary>
    public partial class Form1 : Form
    {
        DataTable DataSource { get; set; } = new DataTable();

        public Form1()
        {
            InitializeComponent();
            MainDataGrid.DataSource = DataSource;
        }

        private void Button_Import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog o = new OpenFileDialog())
            {
                o.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                o.Filter = "Comma-Separated Values (*.csv)|*.csv";
                o.Multiselect = false;
                if (o.ShowDialog() == DialogResult.OK)
                {

                    //Get first line
                    string firstLine;
                    using (StreamReader sr = new StreamReader(o.FileName))
                    {
                        firstLine = sr.ReadLine();
                    }
                    InitializeLargeDataLoadAsync(o.FileName, firstLine);
                }
            }
        }

        private void Button_Export_Click(object sender, EventArgs e)
        {

        }

        private async void InitializeLargeDataLoadAsync(string fileName, string firstLine)
        {
            //Build columns appropriately
            DataSource.Columns.Clear();
            foreach(string s in firstLine.Split(','))
            {
                DataSource.Columns.Add(s);
            }

            MainDataGrid.Enabled = false;
            FileInfo file = new FileInfo(fileName);

            await Task.Factory.StartNew(() => LoadFile(file));
        }

        private void LoadFile(FileInfo file)
        {
            using (StreamReader sr = new StreamReader(file.FullName))
            {
                //nix the first line
                sr.ReadLine();
                
                long currentMemoryRead = 0;

                string line;
                while((line = sr.ReadLine()) != null)
                {
                    currentMemoryRead += Encoding.ASCII.GetByteCount(line);
                    DataSource.Rows.Add(line.Split(','));

                    int percentage = (int)((float)((float)currentMemoryRead / (float)file.Length) * 1000);
                    if (ProgressBar.Value != percentage)
                    {
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            ProgressBar.Value = percentage;
                        }));
                    }
                }
                this.Invoke(new MethodInvoker(delegate ()
                {
                    MainDataGrid.Refresh();
                    ProgressBar.Value = 0;
                    MainDataGrid.ScrollBars = ScrollBars.None;
                    MainDataGrid.Refresh();
                    MainDataGrid.ScrollBars = ScrollBars.Both;
                    MainDataGrid.Enabled = true;
                    MessageBox.Show("Finished Loading all entries", "Message", MessageBoxButtons.OK);
                }));
            }
        }
    }
}
