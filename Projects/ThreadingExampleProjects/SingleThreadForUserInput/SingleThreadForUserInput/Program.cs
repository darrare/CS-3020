using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingleThreadForUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread worker;
            List<Thread> threads = new List<Thread>();
            int input = 0;
            do
            {
                Console.WriteLine("Enter the menu option for what you want to select.");
                Console.WriteLine("1. Count to infinity.");
                Console.WriteLine("2. Print 1-50, in whatever order you want.");
                Console.WriteLine("3. Bubble sort a list of 25000 elements.");
                Console.WriteLine("4. Exit this program.");

                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        worker = new Thread(CountToInfinity);
                        worker.Start();
                        Console.ReadKey();
                        worker.Abort();
                        break;
                    case 2:
                        for(int i = 1; i <= 50; i++)
                        {
                            int h = i;
                            threads.Add(new Thread(() => PrintNumber(h)));
                            threads.Last().Start();
                        }

                        //Important, stops current thread until all return
                        for(int i = 0; i < threads.Count; i++)
                        {
                            threads[i].Join();
                        }
                        break;
                    case 3:
                        List<int> integers = new List<int>();
                        Random rand = new Random();
                        for(int i = 0; i < 25000; i++)
                        {
                            integers.Add(rand.Next(0, 50000));
                        }

                        new Thread(() => BubbleSort(integers)).Start();

                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            } while (input != 4);
        }

        static void BubbleSort(List<int> integers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < integers.Count; i++)
                {
                    if (integers[i - 1] > integers[i])
                    {
                        int temp = integers[i];
                        integers[i] = integers[i - 1];
                        integers[i - 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine("The list has finally been sorted.");
        }

        static void CountToInfinity()
        {
            int index = 0;
            while(true)
            {
                Console.WriteLine(index);
                index++;
                Thread.Sleep(10);
            }
        }

        static void PrintNumber(int i)
        {
            Console.WriteLine(i);
        }
    }
}
