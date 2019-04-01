using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Locking
{
    class Program
    {
        static object resultLocker = new object();
        static int result = 0;
        static void Main(string[] args)
        {
            List<Thread> threads = new List<Thread>();
            for(int i = 0; i < 1000; i++)
            {
                threads.Add(new Thread(() => AddTo(1))); //Create threads
            }
            Thread.Sleep(100); //Sleep to ensure threads are created
            foreach(Thread t in threads)
            {
                t.Start(); //Start each thread
            }
            foreach(Thread t in threads)
            {
                t.Join();
            }
            Console.WriteLine(result); //Is result 1000?
            Console.ReadKey();
        }
        static void AddTo(int i) { lock(resultLocker) result = result + i; }
    }
}
