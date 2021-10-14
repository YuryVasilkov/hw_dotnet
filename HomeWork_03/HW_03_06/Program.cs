using System;

namespace HW_03_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol;
            bool flag = false;
            // Field size is 100x100.
            //Start point is (50, 50)
            int x = 50;
            int y = 100;
            while (!flag)
            {
                Console.WriteLine("Please, move the player. Enter q for exit");
                symbol = Console.ReadLine();

                if (symbol != null)
                {
                    switch (symbol.ToLower())
                    {
                        case "w":
                            {
                                if (y == 100)
                                {
                                    Console.WriteLine("You can't move up!");
                                }
                                else
                                {
                                    y++;
                                    Console.WriteLine("Moving up!");
                                }
                                break;
                            }
                        case "s":
                            {
                                if (y == 0)
                                {
                                    Console.WriteLine("You can't move down!");
                                }
                                else
                                {
                                    y--;
                                    Console.WriteLine("Moving down!");
                                }
                                break;
                            }
                        case "a":
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine("You can't move left!");
                                }
                                else
                                {
                                    x--;
                                    Console.WriteLine("Moving left!");
                                }
                                break;
                            }
                        case "d":
                            {
                                if (x == 100)
                                {
                                    Console.WriteLine("You can't move right!");
                                }
                                else
                                {
                                    x--;
                                    Console.WriteLine("Moving right!");
                                }
                                break;
                            }
                        case "q":
                            {
                                flag = true;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong symbol. Please, try again");
                                break;
                            }
                    }
                }

                if (flag)
                {
                    break;
                }
            }
        }
    }
}
