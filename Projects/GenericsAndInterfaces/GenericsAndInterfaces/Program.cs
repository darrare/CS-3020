using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndInterfaces
{
    class Program
    {
        static Random rand = new Random(8675309);
        static void Main(string[] args)
        {
            BinaryTree t = new BinaryTree();
            for(int i = 0; i < 10; i++)
            {
                t.Insert(rand.Next(0, 100));
            }

            t.PreOrderPrint();
            t.InOrderPrint();
            t.PostOrderPrint();

            while(true)
            {
                int input = int.Parse(Console.ReadLine());
                t.Remove(input);
            }
            
        }
    }
}
