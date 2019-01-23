using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    class Example2
    {
        //[static?] [return type] [identifier] (parameters)
        void Mai(string[] args)
        {
            Car c = new Car();
            c.engine = "V6"; //Set car engine to V6
            PassingByReference(c);
            //Car's engine is a V8 here!

            int val = 5; //Set val to 5
            PassingByValue(val);
            //val's value is still 5!

            int val2 = 5; //Set val2 to 5
            val2 = PassingByValue(val2);
            //val2's value is now 25!
        }

        void PassingByReference(Car car)
        {
            car.engine = "V8";
        }

        int PassingByValue(int a)
        {
            a = a * a;
            return a;
        }
    }
}


