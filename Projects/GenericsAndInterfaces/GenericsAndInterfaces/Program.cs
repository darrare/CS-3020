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
            BinaryTree<int> t = new BinaryTree<int>();
            for(int i = 0; i < 10; i++)
            {
                t.Insert(rand.Next(0, 100));
            }

            //Do debugging here

            BinaryTree<Person> peopleTree = new BinaryTree<Person>();
            for (int i = 0; i < 10; i++)
            {
                peopleTree.Insert(new Person("person" + i, (float)rand.NextDouble() * 100 + 100, (float)rand.NextDouble() * 40 + 50));
            }

            Console.WriteLine("10 people randomly created and added to the tree. Compared by height.");

            Console.WriteLine("Pre Order Print");
            peopleTree.PreOrderPrint();
            Console.WriteLine("\nIn Order Print");
            peopleTree.InOrderPrint();
            Console.WriteLine("\nPost Order Print");
            peopleTree.PostOrderPrint();

        }
    }
}
