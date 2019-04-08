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

namespace DepthFirstSearch
{
    class Graph
    {
        public Node[,] Map { get; set; } = new Node[50, 50];

        public Node StartNode { get; set; }
        public Node EndNode { get; set; }

        Random rand = new Random(8675309);

        Form1 Form;

        public Graph(Form1 form)
        {
            Form = form;

            //Set up nodes
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    Map[x, y] = new Node(x, y);
                }
            }

            //Set up neighbors
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    List<Node> neighbors = new List<Node>();


                    if (x != 49 && y != 0)
                        neighbors.Add(Map[x + 1, y - 1]);
                    if (x != 49)
                        neighbors.Add(Map[x + 1, y]);
                    if (y != 0)
                        neighbors.Add(Map[x, y - 1]);
                    if (x != 49 && y != 49)
                        neighbors.Add(Map[x + 1, y + 1]);
                    if (x != 0 && y != 0)
                        neighbors.Add(Map[x - 1, y - 1]);
                    if (y != 49)
                        neighbors.Add(Map[x, y + 1]);
                    if (x != 0)
                        neighbors.Add(Map[x - 1, y]);
                    if (x != 0 && y != 49)
                        neighbors.Add(Map[x - 1, y + 1]);



                    //for (int i = -1; i <= 1; i++)
                    //{
                    //    for (int k = -1; k <= 1; k++)
                    //    {
                    //        if ((i != 0 || k != 0)               //Don't add self as neighbor
                    //            && (x + i >= 0 && x + i < 50)   //Don't add out of bounds horizontal
                    //            && (y + k >= 0 && y + k < 50))  //Don't add out of bounds veritcal
                    //        {
                    //            neighbors.Add(Map[x + i, y + k]);
                    //        }
                    //    }
                    //}
                    Map[x, y].Neighbors = neighbors;
                }
            }
        }

        public void RandomizeGraph()
        {
            ResetGraph();
            float percentageCoverage = .35f;
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    if (rand.NextDouble() < percentageCoverage)
                    {
                        Map[x, y].IsObstacle = true;
                        Form.AlterNodeColor(x, y, Color.Black);
                    }
                    else
                    {
                        Map[x, y].IsObstacle = false;
                        Form.AlterNodeColor(x, y, Color.White);
                    }
                }
            }

            StartNode = Map[rand.Next(0, 50), rand.Next(0, 50)];
            StartNode.IsObstacle = false;
            Form.AlterNodeColor(StartNode.X, StartNode.Y, Color.ForestGreen);
            do
            {
                EndNode = Map[rand.Next(0, 50), rand.Next(0, 50)];
                Form.AlterNodeColor(EndNode.X, EndNode.Y, Color.Red);
            } while (StartNode == EndNode) ;
            EndNode.IsObstacle = false;
        }

        #region Pathfinding
        Stack stack = new Stack();


        public void SolveGraph(int delay = 0)
        {
            ResetGraph();
            StartNode.BackLength = 0;
            stack.Push(StartNode);
            while(stack.Count() > 0)
            {
                Node curNode = stack.Pop();
                curNode.IsVisited = true;
                Form.AlterNodeColor(curNode.X, curNode.Y, Color.Blue);

                foreach (Node n in curNode.Neighbors.Where(t => t.IsObstacle == false))
                {
                    if (n.BackLength >= curNode.BackLength + Distance(n.X, curNode.X, n.Y, curNode.Y))
                    {
                        n.Backnode = curNode;
                        n.BackLength = curNode.BackLength + Distance(n.X, curNode.X, n.Y, curNode.Y);
                    }
                    if (n.IsVisited)
                    {
                        continue;
                    }
                    stack.Push(n);
                    Form.AlterNodeColor(n.X, n.Y, Color.Aqua);
                        
                    if (n == EndNode)
                    {
                        //Found path
                        curNode = n;
                        while (curNode != StartNode)
                        {
                            Form.AlterNodeColor(curNode.X, curNode.Y, Color.Yellow);
                            curNode = curNode.Backnode;
                            Form.Update();
                            if (delay != 0)
                                Thread.Sleep(delay * 10);
                        }
                        return;
                    }
                }
                if (delay != 0)
                {
                    Form.Update();
                    Thread.Sleep(delay);
                }
            }
            Console.WriteLine("False");
        }

        public bool SolveGraphIteratively()
        {
            return false;
        }

        public void ResetGraph()
        {
            stack.Clear();
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    Map[x, y].IsVisited = false;
                    Map[x, y].Backnode = null;
                    Map[x, y].BackLength = double.MaxValue;
                }
            }
        }

        private double Distance(int x1, int x2, int y1, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2) == 2 ? 1.414214 : 1;
        }

        #endregion
    }
}
