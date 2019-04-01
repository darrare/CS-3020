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
            List<int> values = new List<int>();
            for (int i = 1; i < 1000; i++)
            {
                values.Add(i);
            }

            var results = values.Select(a1 =>
            {
                return values.Select(a2 =>
                {
                    if ((a1 * a2).ToString() == new string((a1 * a2).ToString().Reverse().ToArray()))
                    {
                        return new { arg1 = a1, arg2 = a2, large = a1 * a2 };
                    }
                    return new { arg1 = 0, arg2 = 0, large = 0 };
                }).Where(g => g.large != 0);
            });

            int largest = 0;
            int arg1 = 0;
            int arg2 = 0;
            foreach (var res in results)
            {
                foreach(var r in res)
                {
                    if (r.large > largest)
                    {
                        largest = r.large;
                        arg1 = r.arg1;
                        arg2 = r.arg2;
                    }
                    Console.WriteLine("Arguments " + r.arg1 + " and " + r.arg2 + " make palindromic number " + r.large);
                }
            }

            Console.WriteLine("\nThe largest palindrome made from the product of two 3-digit numbers is:");
            Console.WriteLine(largest + " made from the product of " + arg1 + " and " + arg2);


            return;


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

            #region Add 1000 to every element in a list, but still keep the original values (.Select) (List.AddRange)
            integers = ResetListInt();
            //Replace the following for loop with 1 LINQ statement
            for(int i = 0; i < integers.Count; i++)
            {
                integers.Add(1000 + integers[i]);
            }

            //Integers now contains the original elements, plus all the original elements + 1000
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
