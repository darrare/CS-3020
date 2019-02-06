using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Debugging
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Please enter an integer value for the action you want to perform.");
                Console.WriteLine("1. Print all multiples of 3 or 5 between selected values.");
                Console.WriteLine("2. Create an array of n random integers.");
                Console.WriteLine("3. Convert Fahrenheit to Celsius.");
                Console.WriteLine("4. Read a file and figure out how much money is there.");
                Console.WriteLine("5. End the program");
                Console.WriteLine("------------------------------------------------------------------");

                userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Please enter the lower bound to check multiples:");
                        int lowerBound = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the upper bound to check multiples:");
                        int upperBound = int.Parse(Console.ReadLine());
                        MultiplesOfThreeAndFive(lowerBound, upperBound);
                        break;
                    case 2:
                        Console.WriteLine("Please enter the number of elements you want to add to the array:");
                        int n = int.Parse(Console.ReadLine());
                        CreateArrayOfRandomIntegers(n);
                        break;
                    case 3:
                        Console.WriteLine("Please enter a floating point number representing Fahrenheit:");
                        float fahrenheit = float.Parse(Console.ReadLine());
                        ConvertFahrenheitToCelsius(fahrenheit);
                        break;
                    case 4:
                        Console.WriteLine("Reading file to find out how much money is listed in it.");
                        FromFileSumCurrency();
                        break;
                    case 5:
                        Console.WriteLine("Thanks for using the program.");
                        break;
                    default:
                        break;
                }
            } while (userInput != 5);
        }

        /// <summary>
        /// Prints all multiples of 3 and 5 within the two bounds (inclusive)
        /// </summary>
        /// <param name="lowerBound">The lowest value to consider</param>
        /// <param name="upperBound">The highest value to consider</param>
        static void MultiplesOfThreeAndFive(int lowerBound, int upperBound)
        {
            for(int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i + " is a multiple of 3 or 5.");
                }
            }
        }

        
        /// <summary>
        /// Creates an array of random integers
        /// </summary>
        /// <param name="sizeOfArray">Size of array</param>
        static void CreateArrayOfRandomIntegers(int sizeOfArray)
        {
            int[] myArray = new int[2];
            for(int i = 0; i <= sizeOfArray; i++)
            {
                myArray[i] = rand.Next(0, 1000);
            }

            for(int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine("Element " + i + " = " + myArray[i]);
            }
        }

        /// <summary>
        /// Converts a fahrenheit argument to celsius and prints
        /// </summary>
        /// <param name="fahrenheit">The fahrenheit value to convert</param>
        static void ConvertFahrenheitToCelsius(float fahrenheit)
        {
            //formula = (fahrenheit°F − 32) × (5/9) = celsius°C
            //use google to verify your input
            Console.Write(fahrenheit + " degrees Fahrenheit is ");
            float modifer = (5 / 9);
            float celsius = (fahrenheit - 32) * modifer;
            Console.WriteLine(celsius + " degrees celsius.");
        }

        /// <summary>
        /// Reads a file with an input similar to:
        /// 
        /// QUARTER=31
        /// DIME=5
        /// NICKEL=2
        /// DIME=7
        /// HALFDOLLAR=0
        /// BUBBLES=10
        /// PENNY=157
        /// 
        /// Program should open file and calculate the value of the currency.
        /// Any name stated twice (dime in the above example) should be added together and both considered to the ultimate sum.
        /// Any name that is an invalid coin (bubbles in the above example) should be completely ignored.
        /// </summary>
        static void FromFileSumCurrency()
        {
            //Reads in a file Prob01.in.txt
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Prob01.in.txt";

            //Creates a list to store each line of the file
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                //As long as lines remain, continue adding them
                while((line = sr.ReadLine()) == null)
                {
                    lines.Add(line);
                }
            }

            //Create a dictionary to store values
            Dictionary<string, float> currency = new Dictionary<string, float>();

            //For each possible type of coin, sum every line containing that coin and turn it into dollar format (half dollar = .5 dollars)
            currency.Add("HALFDOLLAR", lines.Sum(t => t.Contains("HALFDOLLAR") ? float.Parse(t.Substring(10)) * .5f : 0));
            currency.Add("QUARTER", lines.Sum(t => t.Contains("QUARTER") ? float.Parse(t.Substring(7)) * .25f : 0));
            currency.Add("DIME", lines.Sum(t => t.Contains("DIME") ? float.Parse(t.Substring(4)) * .1f : 0));
            currency.Add("NICKEL", lines.Sum(t => t.Contains("NICKEL") ? float.Parse(t.Substring(6)) * .5f : 0));
            currency.Add("PENNY", lines.Sum(t => t.Contains("PENNY") ? float.Parse(t.Substring(5)) * .1f : 0));

            //Output should be formated to 2 decimal places = $260.30
            Console.WriteLine("Total currency = $" + currency.Sum(t => t.Value).ToString("0.##"));
        }
    }
}
