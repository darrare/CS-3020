using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Program
    {
        static Character player1 = null;
        static Character player2 = null;

        static void Main(string[] args)
        {
            PickCharacters();

            PrintGame();
            bool p1Turn = player1.Priority <= player2.Priority;
            int intChoice;
            do
            {
                Console.WriteLine();
                if (p1Turn)
                {
                player1:
                    Console.WriteLine("Player 1, what do you choose to do?");
                    Console.WriteLine("1. Move and attack " + player1.GetMovementAttackDescription());
                    Console.WriteLine("2. Special " + player1.GetSpecialDescription());
                    if (!int.TryParse(Console.ReadLine(), out intChoice))
                    {
                        Console.WriteLine("input not an integer, please input 1 or 2");
                        goto player1;
                    }
                    switch (intChoice)
                    {
                        case 1:
                            Console.WriteLine("How many units do you want to move?");
                            if (player1.Move(int.Parse(Console.ReadLine())))
                            {
                                Console.WriteLine("You moved");
                            Player1AttacKQuestion:
                                Console.WriteLine("Would you like to attack? y/n");
                                string input = Console.ReadLine();
                                if (input[0] == 'y' || input[0] == 'Y')
                                {
                                    Console.WriteLine("You have opted to attack.");
                                    if (player1.Attack(player2))
                                    {
                                        Console.WriteLine("Your hit has landed.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You are too far away to attack.");
                                    }
                                }
                                else if (input[0] == 'n' || input[0] == 'N')
                                {
                                    Console.WriteLine("You have opted to not attack.");
                                }
                                else
                                {
                                    Console.WriteLine("You have entered an incorrect value. Try again.");
                                    goto Player1AttacKQuestion;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You can't move that far!");
                                goto case 1;
                            }
                            break;
                        case 2:
                            Console.WriteLine("You have opted for your special attack.");
                            Console.WriteLine(player1.Special(player2));
                            break;
                        default:
                            Console.WriteLine("You have entered an incorrect key. Please try again.");
                            goto player1;
                    }
                }
                else
                {
                player2:
                    Console.WriteLine("Player 2, what do you choose to do?");
                    Console.WriteLine("1. Move and attack " + player2.GetMovementAttackDescription());
                    Console.WriteLine("2. Special " + player2.GetSpecialDescription());
                    if (!int.TryParse(Console.ReadLine(), out intChoice))
                    {
                        Console.WriteLine("input not an integer, please input 1 or 2");
                        goto player2;
                    }
                    switch (intChoice)
                    {
                        case 1:
                            Console.WriteLine("How many units do you want to move?");
                            if (player2.Move(int.Parse(Console.ReadLine())))
                            {
                                Console.WriteLine("You moved");
                            Player2AttacKQuestion:
                                Console.WriteLine("Would you like to attack? y/n");
                                string input = Console.ReadLine();
                                if (input[0] == 'y' || input[0] == 'Y')
                                {
                                    Console.WriteLine("You have opted to attack.");
                                    if (player2.Attack(player1))
                                    {
                                        Console.WriteLine("Your hit has landed.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You are too far away to attack.");
                                    }
                                }
                                else if (input[0] == 'n' || input[0] == 'N')
                                {
                                    Console.WriteLine("You have opted to not attack.");
                                }
                                else
                                {
                                    Console.WriteLine("You have entered an incorrect value. Try again.");
                                    goto Player2AttacKQuestion;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You can't move that far!");
                                goto case 1;
                            }
                            break;
                        case 2:
                            Console.WriteLine("You have opted for your special attack.");
                            Console.WriteLine(player2.Special(player1));
                            break;
                        default:
                            Console.WriteLine("You have entered an incorrect key. Please try again.");
                            goto player2;
                    }
                }
                PrintGame();
                p1Turn = !p1Turn;
            } while (player1.Health > 0 && player2.Health > 0);

            if (player1.Health == 0)
            {
                Console.WriteLine("Player 2 wins!");
            }
            else if (player2.Health == 0)
            {
                Console.WriteLine("Player 1 wins!");
            }
        }

        private static void PickCharacters()
        {
            Console.WriteLine("Player 1, what class do you choose? m,w,a?");
            char choice = Console.ReadLine()[0];
            switch (choice)
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
        }

        static void PrintGame()
        {
            Console.WriteLine();
            for (int i = 0; i < 50; i++)
            {
                if (player1.Position == i + 1)
                {
                    Console.Write("1");
                }
                if(player2.Position == i + 1)
                {
                    Console.Write("2");
                }
                if (player2.Position != i + 1 && player1.Position != i + 1)
                {
                    Console.Write('-');
                }
            }
            Console.WriteLine();
            Console.WriteLine("Player 1 HP: " + player1.Health + " - Player 2 HP: " + player2.Health);
        }
    }
}
