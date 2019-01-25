using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tiles = new char[50];
            for (int i = 0; i < tiles.Length; i++)
                tiles[i] = '-';

            Character player1 = null;
            Character player2 = null;

            Console.WriteLine("Player 1, what class do you choose? m,w,a?");
            char choice = Console.ReadLine()[0];
            switch(choice)
            {
                case 'm':
                    player1 = new Mage(23);
                    break;
                case 'w':
                    player1 = new Warrior(23);
                    break;
                case 'a':
                    player1 = new Archer(23);
                    break;
            }

            Console.WriteLine("Player 2, what class do you choose? m,w,a?");
            choice = Console.ReadLine()[0];
            switch (choice)
            {
                case 'm':
                    player2 = new Mage(28);
                    break;
                case 'w':
                    player2 = new Warrior(28);
                    break;
                case 'a':
                    player2 = new Archer(28);
                    break;
            }

            int intChoice;
            do
            {
                if (player1.Priority <= player2.Priority)
                {
                    player1:
                    Console.WriteLine("Player 1, what do you choose to do?");
                    Console.WriteLine("1. Move and attack");
                    Console.WriteLine("2. Special");
                    intChoice = int.Parse(Console.ReadLine());
                    switch (intChoice)
                    {
                        case 1:
                            Console.WriteLine("How many units do you want to move?");
                            if (player1.Move(int.Parse(Console.ReadLine())))
                            {

                            }
                            else
                            {
                                Console.WriteLine("You can't move that far!");
                                goto case 1;
                            }
                            break;
                        case 2:
                            break;
                        default:
                            Console.WriteLine("You have entered an incorrect key. Please try again.");
                            goto player1;
                    }

                    
                }
                else
                {

                }
            } while (player1.Health > 0 && player2.Health > 0);
        }
    }
}
