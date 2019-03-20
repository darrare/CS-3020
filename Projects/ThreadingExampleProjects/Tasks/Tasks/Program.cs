using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Tasks
{
    class Program
    {
        //10000x10000 = 100,000,000
        //1000x100000 = 100,000,000
        //100x1000000 = 100,000,000
        //10x10000000 = 100,000,000
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            List<Task> tasks = new List<Task>();

            int threadCount = 10000;
            int threadIterations = 10000;

            double temp = 0;
            for (int i = 0; i < threadCount; i++)
            {
                int h = i;
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < threadIterations; j++)
                    {
                        temp = Math.Sqrt(Math.Pow(j, 2) + i);
                    }
                }));
            }

            foreach (Task t in tasks)
                t.Wait();

            //for (int i = 0; i < threadCount; i++)
            //{
            //    for (int j = 0; j < threadIterations; j++)
            //    {
            //        temp = Math.Sqrt(Math.Pow(j, 2) + i);
            //    }
            //}



            timer.Stop();
            Console.WriteLine((float)timer.ElapsedMilliseconds / 1000f + " seconds elapsed");
            Console.ReadKey();
        }
    }
}
