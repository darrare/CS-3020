using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
{
    class Stack
    {
        List<Node> Elements = new List<Node>();
        public Stack() { }

        public void Push(Node n)
        {
            Elements.Add(n);
        }

        public Node Pop()
        {
            Node temp = Elements.Last();
            Elements.RemoveAt(Elements.Count - 1);
            return temp;
        }

        public Node Peek()
        {
            return Elements.Last();
        }

        public void Clear()
        {
            Elements.Clear();
        }

        public int Count()
        {
            return Elements.Count();
        }
    }
}
