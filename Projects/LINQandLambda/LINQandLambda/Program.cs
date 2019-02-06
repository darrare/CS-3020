using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQandLambda
{
    class Program
    {
        static Random rand = new Random(1234);
        static void Main(string[] args)
        {
            Console.WriteLine(@"Hello\n");
            Console.WriteLine("World");



            List<int> integers = ResetListInt();

            #region Randomly sort integers (.OrderBy)
            //Replace the following 7 lines with 1 LINQ statement
            List<int> tempList = new List<int>();
            for(int i = integers.Count - 1; i >= 0; i--)
            {
                tempList.Add(integers[rand.Next(0, i)]);
            }
            integers = new List<int>(tempList);
            tempList.Clear();
            //integers is now randomly sorted.
            #endregion

            #region Sort integers (.OrderBy)
            integers = ResetListInt();
            //Replace this bubble sort algorithm with 1 LINQ statement.
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < integers.Count; i++)
                {
                    if (integers[i - 1] > integers[i])
                    {
                        int temp = integers[i];
                        integers[i] = integers[i - 1];
                        integers[i - 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            //integers is now sorted
            #endregion

            #region Find all even values (.Where)
            integers = ResetListInt();
            tempList = new List<int>();
            //Assuming list isn't already sorted
            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] % 2 == 0)
                    tempList.Add(integers[i]);
            }
            integers = new List<int>(tempList);
            //integers is now only the even values from the original set of numbers
            tempList.Clear();
            #endregion

            #region Combine two lists (.Select) (.Union)
            integers = ResetListInt();
            List<int> otherIntegers = new List<int>();
            //Replace the following for loop with 1 LINQ statement
            for(int i = 0; i < integers.Count; i++)
            {
                otherIntegers.Add(1000 + integers[i]);
            }

            //Replace the following for loop with 1 LINQ statement
            for (int i = 0; i < otherIntegers.Count; i++)
            {
                integers.Add(otherIntegers[i]);
            }

            #endregion

        }

        static List<int> ResetListInt()
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                integers.Add(i);
            }
            return integers;
        }
    }
}
