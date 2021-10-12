using System;

namespace HW_03_04
{
    class Program
    {
        static void Main(string[] args)
        {
                int addNumber(string number)
                {
                    Console.WriteLine("Please, input {0} number", number);
                    string num1 = Console.ReadLine();
                    while (!int.TryParse(num1, out int num))
                    {
                        Console.WriteLine("Incorrect data. Please, try again");
                        num1 = Console.ReadLine();
                    }

                    return Convert.ToInt32(num1);
                }

                Console.WriteLine("Please, input the sign of operation/ ( + or -)");
                int result;
                string sign;
                while(true)
                {
                    sign = Console.ReadLine();
                    if (sign == "+")
                    {
                        result = addNumber("first") + addNumber("second");
                        break;
                    }
                    else if (sign == "-")
                    {
                        result = addNumber("first") - addNumber("second");
                        break;
                    }
                    else
                        Console.WriteLine("Incorrect sign. Please try again.");
                }
                
                Console.WriteLine("What will be the result?");
                int intentedResult;
                while (true)
                {
                    intentedResult = addNumber("intented");
                    if (result == intentedResult)
                    {
                        Console.WriteLine("Correct! :)");
                        break;
                    }
                    else if (result < intentedResult)
                    {
                        Console.WriteLine("Incorrect :(. Result will be less. Please, try again.");
                    }
                    else
                        Console.WriteLine("Incorrect :(. Result will be more. Please, try again.");
                }
            }
        }
    }
