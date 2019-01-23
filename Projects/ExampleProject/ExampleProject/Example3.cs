using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    class Example3
    {
        void Main(string[] args)
        {
            Car car = new Car();

            for(; !FillVehicleToPercentage(car, .8f); Console.WriteLine("Filling vehicle"))
            {

            }
        }

        bool FillVehicleToPercentage(Car c, float val)
        {
            if (c.gasPercentage <= val)
                c.gasPercentage += .1f;

            if (c.gasPercentage >= val)
                return true;
            return false;
        }
    }
}


