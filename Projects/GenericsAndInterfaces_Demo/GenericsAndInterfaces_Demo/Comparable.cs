using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndInterfaces_Demo
{
    class Currency : IComparable<Currency>
    {
        public int gold = 0;
        public int silver = 0;
        public int copper = 0;

        public Currency(int gold, int silver, int copper)
        {
            this.gold = gold;
            this.silver = silver;
            this.copper = copper;
        }

        private int GetComparableValue()
        {
            return gold * 10000 + silver * 100 + copper;
        }

        public int CompareTo(Currency other)
        {
            if (other == null)
                return 1;
            else if (GetComparableValue() < other.GetComparableValue())
                return -1;
            else if (GetComparableValue() > other.GetComparableValue())
                return 1;
            else
                return 0;
        }

        public static bool operator > (Currency a, Currency b)
        {
            return a.CompareTo(b) == 1;
        }

        public static bool operator < (Currency a, Currency b)
        {
            return a.CompareTo(b) == -1;
        }

        public static bool operator >= (Currency a, Currency b)
        {
            return a.CompareTo(b) >= 0;
        }

        public static bool operator <= (Currency a, Currency b)
        {
            return a.CompareTo(b) <= 0;
        }

        public static bool operator == (Currency a, Currency b)
        {
            return a.CompareTo(b) == 0;
        }

        public static bool operator != (Currency a, Currency b)
        {
            return a.CompareTo(b) != 0;
        }
    }
}
