using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingRefOut
{
    class Currency
    {
        int gold;
        int silver;
        int copper;
        public Currency(int gold, int silver, int copper)
        {
            this.gold = gold;
            this.silver = silver;
            this.copper = copper;
        }

        public static Currency operator + (Currency A, Currency B)
        {
            return new Currency(A.gold + B.gold, A.silver + B.silver, A.copper + B.copper);
        }

        public static Currency operator - (Currency A, Currency B)
        {
            //Probably should do some checking here so we don't go into the negative. Instead just set to 0.
            return new Currency(A.gold - B.gold, A.silver - B.silver, A.copper - B.copper);
        }

        public static Currency operator - (Currency A)
        {
            return new Currency(-A.gold, -A.silver, -A.copper);
        }

        public int GetRawValue()
        {
            return gold * 10000 + silver * 100 + copper;
        }

        public static bool operator true (Currency A)
        {
            return A.GetRawValue() >= 500000;
        }

        public static bool operator false (Currency A)
        {
            return A.GetRawValue() < 500000;
        }

        public override string ToString()
        {
            return "Gold: " + gold + ".\n"
                + "Silver: " + silver + ".\n"
                + "Copper: " + copper + ".\n";
        }
    }
}
