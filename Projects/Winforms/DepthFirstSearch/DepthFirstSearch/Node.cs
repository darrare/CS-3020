using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
{
    class Node
    {
        public bool IsVisited { get; set; }
        public bool IsObstacle { get; set; } = false;
        
        public int X { get; set; }

        public int Y { get; set; }

        public List<Node> Neighbors { get; set; } = new List<Node>();

        public Node Backnode { get; set; }

        public double BackLength { get; set; } = double.MaxValue;

        public Node(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
