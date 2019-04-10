using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    class Reflector
    {
        List<int> outputIndex = new List<int>();

        public Reflector(List<int> outputIndex)
        {
            this.outputIndex = outputIndex;
        }

        public int Input(int val)
        {
            return outputIndex[val];
        }
    }
}
