using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLooping = true;
            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Enter the following to perform an action.");
                Console.WriteLine("1. Convert Fahrenheit to Celsius.");
                Console.WriteLine("2. Calculate volume of a sphere");
                Console.WriteLine("3. Prints all values <= n that are multiples of 3 or 5");
                Console.WriteLine("4. Check to see if string is palindrome.");
                Console.WriteLine("5. Exit the program");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Please enter an input: ");
                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        Console.WriteLine("Please enter a value (float) for fahrenheit:");
                        float fahrenheit = float.Parse(Console.ReadLine());
                        Console.WriteLine(fahrenheit + " degrees fahrenheit is " + ((fahrenheit - 32) * (5f / 9f)) + " degrees celsius.");
                        break;
                    case 2:
                        Console.WriteLine("Please enter the radius (float) of your sphere:");
                        float radius = float.Parse(Console.ReadLine());
                        Console.WriteLine("Your sphere's volume is " + ((4f / 3f) * Math.PI * radius * radius * radius));
                        break;
                    case 3:
                        Console.WriteLine("Please enter a maximum value (integer) to check for multiples: ");
                        int max = int.Parse(Console.ReadLine());
                        Console.WriteLine("Printing multiples of 3 or 5:");
                        for(int i = 0; i <= max; i++)
                        {
                            if (i % 3 == 0 || i % 5 == 0)
                                Console.WriteLine(i);
                        }
                        Console.WriteLine("Printing completed...");
                        break;
                    case 4:
                        Console.WriteLine("Please enter a string to check if it is a palindrome or not:");
                        string check = Console.ReadLine();
                        bool isValid = true;
                        for (int i = 0; i < check.Length / 2; i++)
                        {
                            if (check[i] != check[check.Length - 1 - i])
                            {
                                Console.WriteLine(check + " is not a palindrome.");
                                isValid = false;
                                break;
                            }
                        }
                        if (isValid)
                            Console.WriteLine(check + " is a palindrome.");
                        break;
                    case 5:
                        Console.WriteLine("Thankyou for using this program. Exiting...");
                        isLooping = false;
                        break;
                    default:
                        Console.WriteLine("You have entered an incorrect key. Please try again...");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (isLooping);
        }
    }
}




