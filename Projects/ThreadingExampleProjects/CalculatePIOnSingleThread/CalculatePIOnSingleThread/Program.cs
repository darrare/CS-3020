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
                int alternatingOdds = 3;
                while(true)
                {
                    if (isSubTracting)
                    {
                        val -= 1f / alternatingOdds;
                    }
                    else
                    {
                        val += 1f / alternatingOdds;
                    }
                    isSubTracting = !isSubTracting;
                    alternatingOdds += 2;
                    pi = val * 4f;
                }
            });
            Console.WriteLine("Calculating PI started");
            Console.WriteLine("Press any key to get the value at this given time.");
            Console.WriteLine("The true value of pi is: 3.14159265358979");
            Console.ReadKey(); Console.WriteLine();
            Console.WriteLine("The value of pi is: ");
            Console.WriteLine(pi);
            Console.ReadKey();
        }
    }
}
