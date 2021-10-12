﻿using System;

namespace HW_03_03
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

            int result = addNumber("first") + addNumber("second");
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