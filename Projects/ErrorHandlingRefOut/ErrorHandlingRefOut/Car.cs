using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingRefOut
{
    class Car
    {
        public string engine;
        public int year;
        public Car(string engine, int year)
        {
            this.engine = engine;
            this.year = year;
        }

        public void Print()
        {
            Console.WriteLine("Year: " + year + ", with a " + engine + " engine.");
        }
    }
}
