using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DeadlockExample
{
    class Program
    {
        static object a = new object();
        static object b = new object();
        static int a_val = 3;
        static int b_val = 5;
        static void Main(string[] args)
        {
            Thread A = new Thread(AWork);
            Thread B = new Thread(BWork);
            A.Start(); B.Start();
            A.Join(); B.Join();
            Console.WriteLine(a_val); Console.WriteLine(b_val);
            Console.ReadKey();
        }
        static void AWork()
        {
            lock(a)
            {
                a_val = a_val + b_val;
                lock (b)
                    b_val = a_val + b_val;
            }
        }
        static void BWork()
        {
            lock (b)
            {
                b_val = a_val + b_val;
                lock (a)
                    a_val = a_val + b_val;
            }
        }
    }
}
