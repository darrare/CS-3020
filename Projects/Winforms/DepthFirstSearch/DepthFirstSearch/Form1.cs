using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepthFirstSearch
{
    public partial class Form1 : Form
    {
        Bitmap map;
        Random rand = new Random();

        Graph graph;

        public Form1()
        {
            InitializeComponent();
            map = new Bitmap(PictureBox_Map.Width, PictureBox_Map.Height);
            for (int i = 0; i < PictureBox_Map.Width; i++)
            {
                for (int j = 0; j < PictureBox_Map.Height; j++)
                {
                    map.SetPixel(i, j, Color.White);
                }
            }
            graph = new Graph(this);
            Button_RandomizeMap_Click(null, null);
        }

        private void Button_FindPathInstant_Click(object sender, EventArgs e)
        {
            graph.SolveGraph();
        }

        private void Button_FindPathIteration_Click(object sender, EventArgs e)
        {
            graph.SolveGraph(10);
        }

        private void Button_RandomizeMap_Click(object sender, EventArgs e)
        {
            graph.RandomizeGraph();
        }

        public void AlterNodeColor(int x, int y, Color c)
        {
            for (int i = x * 10; i < x * 10 + 10; i++)
            {
                for (int j = y * 10; j < y * 10 + 10; j++)
                {
                    map.SetPixel(i, j, c);
                }
            }
            PictureBox_Map.Image = map;
        }
    }
}
