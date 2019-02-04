using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingRefOut
{
    class SomeCollectionClass
    {
        int[] array = new int[10];

        public SomeCollectionClass() { }

        public int this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }
}
