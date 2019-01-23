using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    enum CarState { On, Off, Idle, Stopped, Parked, Accelerating, Decelerating, Totaled, Full, Empty }
    class Car
    {
        CarState state = CarState.On;
        public string engine;
        public float gasPercentage = 0;

        public Car()
        {
            switch (state)
            {
                case CarState.On:
                    //Do on stuff
                    break;
                case CarState.Off:
                    //Do off stuff
                    break;
                case CarState.Idle:
                    break;
                case CarState.Stopped:
                    break;
                case CarState.Parked:
                    break;
                case CarState.Accelerating:
                    break;
                case CarState.Decelerating:
                    break;
                case CarState.Totaled:
                    break;
                case CarState.Full:
                    break;
                case CarState.Empty:
                    break;
                default:
                    break;
            }
        }

        public void Vroom()
        {
            Console.WriteLine("Vroom");
        }
    }
}
