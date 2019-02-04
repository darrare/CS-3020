using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingRefOut
{
    class Fahrenheit
    {
        float val;
        public Fahrenheit(float val)
        {
            this.val = val;
        }

        public static explicit operator Celsius(Fahrenheit fahr)
        {
            return new Celsius((5.0f / 9.0f) * (fahr.val - 32));
        }
    }
}
