using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    class Machine
    {
        Rotor left;
        Rotor middle;
        Rotor right;
        Reflector reflector;

        public Machine(Rotor left, int leftStartingPosition, Rotor middle, int middleStartingPosition, Rotor right, int rightStartingPosition, Reflector reflector)
        {
            this.left = left;
            for (int i = 0; i < leftStartingPosition; i++)
                left.Rotate();
            this.left.originalPosition = leftStartingPosition;
            this.middle = middle;
            for (int i = 0; i < middleStartingPosition; i++)
                middle.Rotate();
            this.middle.originalPosition = middleStartingPosition;
            this.right = right;
            for (int i = 0; i < rightStartingPosition; i++)
                right.Rotate();
            this.right.originalPosition = rightStartingPosition;
            this.reflector = reflector;
        }

        public int InputValue(int i)
        {
            int result = right.Input(middle.Input(left.Input(i)));
            result = reflector.Input(result);
            result = left.InputReverse(middle.InputReverse(right.InputReverse(result)));
            
            RotateRotors();
            return result;
        }

        void RotateRotors()
        {
            if (right.Rotate())
            {
                if(middle.Rotate())
                {
                    left.Rotate();
                }
            }
        }
    }
}
