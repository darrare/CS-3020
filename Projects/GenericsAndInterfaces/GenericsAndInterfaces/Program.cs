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
        //The above seed produces a tree that looks like the following when adding integers
        /*             75
         *       57         99
         *    50    65    93
         *  6      58       98
         *   20
         */
        static void Main(string[] args)
        {
            BinaryTree t = new BinaryTree();
            for(int i = 0; i < 10; i++)
            {
                t.Insert(rand.Next(0, 100));
            }

            //Do debugging here


            
        }
    }
}
