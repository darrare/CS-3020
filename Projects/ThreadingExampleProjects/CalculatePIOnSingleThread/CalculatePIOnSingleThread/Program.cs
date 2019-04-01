using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePIOnSingleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 0;
            Task t = Task.Factory.StartNew(() =>
            {
                double val = 1;
                bool isSubTracting = true;
                long alternatingOdds = 3;
                while(true)
                {
                    if (isSubTracting)
                    {
                        val -= 1d / alternatingOdds;
                    }
                    else
                    {
                        val += 1d / alternatingOdds;
                    }
                    isSubTracting = !isSubTracting;
                    alternatingOdds += 2;
                    pi = val * 4d;
                }
            });
            Console.WriteLine("Calculating PI started");
            Console.WriteLine("Press any key to get the value at this given time.");
            Console.WriteLine("The true value of pi is: 3.14159265358979");
            while (true)
            {
                Console.ReadKey(); Console.WriteLine();
                Console.WriteLine("The current value of pi is: ");
                Console.WriteLine(pi);
            }

        }
    }
}
