using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit f = new Fahrenheit(100);
            Celsius c = (Celsius)f;

            Celsius c2 = new Celsius(100);
            Fahrenheit f2 = c2;

            return;
            int userInput = 0;
            do
            {
                userInput = Menu(userInput);
            } while (userInput != 4);
            Console.WriteLine("Thanks for using the program");
        }

        static int Menu(int userInput)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Please enter an input for the command you want to issue.");
            Console.WriteLine("1. Do something with 2 integers.");
            Console.WriteLine("2. Do something with a string");
            Console.WriteLine("3. Do something with a character");
            Console.WriteLine("4. Terminate program");
            Console.WriteLine("--------------------------------------");

            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    DoSomethingWithTwoInts(5, 6);
                    break;
                case 2:
                    DoSomethingWithAString("Hello World");
                    break;
                case 3:
                    DoSomethingWithACharacter('c');
                    break;
            }
            return userInput;
        }

        static void DoSomethingWithTwoInts(int a, int b)
        {
            Console.WriteLine("doing something with two ints");
        }

        static void DoSomethingWithAString(string s)
        {
            Console.WriteLine("doing something with one string");
        }

        static void DoSomethingWithACharacter(char c)
        {
            Console.WriteLine("doing something with one character");
        }
    }
}
