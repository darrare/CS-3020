using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    class Rotor
    {
        List<int> offsets = new List<int>();
        int position = 0;
        public int originalPosition = 0;

        public Rotor(List<int> offsets, int position = 0)
        {
            this.offsets = offsets;
            this.position = position;
        }

        public Rotor(Rotor r)
        {
            for (int i = 0; i < r.offsets.Count; i++)
            {
                offsets.Add(r.offsets[i]);
            } 
            position = r.position;
            originalPosition = r.originalPosition;
        }

        public int Input(int val)
        {
            if (val + offsets[val] < offsets.Count)
            {
                return val + offsets[val];
            }
            else
            {
                return val + offsets[val] - offsets.Count;
            }
        }

        public int InputReverse(int val)
        {
            for (int i = 0; i < offsets.Count; i++)
            {
                if (i + offsets[i] >= offsets.Count)
                {
                    if (i + offsets[i] - offsets.Count == val)
                    {
                        return i;
                    }
                }
                else
                {
                    if (i + offsets[i] == val)
                    {
                        return i;
                    }
                }

            }
            return 0;
        }

        /// <summary>
        /// Rotates the rotor
        /// </summary>
        /// <returns>
        /// True: if the previous rotor needs to be rotated.
        /// False: if the previous rotor does not need to be rotated.
        /// </returns>
        public bool Rotate()
        {
            offsets.Insert(0, offsets.Last());
            offsets.RemoveAt(offsets.Count - 1);

            position++;
            if (position == offsets.Count)
            {
                position = 0;
            }
            if (position == originalPosition)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}
