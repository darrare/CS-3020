using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingRefOut
{
    class Celsius
    {
        float val;
        public Celsius(float val)
        {
            this.val = val;
        }

        public static implicit operator Fahrenheit(Celsius cel)
        {
            return new Fahrenheit((cel.val * (9.0f / 5.0f)) + 32);
        }
    }
}
