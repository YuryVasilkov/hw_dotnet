﻿using System;

namespace HW_03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int AddNumber(string number)
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

            int result = AddNumber("first") + AddNumber("second");
            Console.WriteLine("What will be the result?");
            int intentedResult;

            while (true)
            {
                intentedResult = AddNumber("intented");
                if (result == intentedResult)
                {
                    Console.WriteLine("Correct! :)");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect :(. Please, try again.");
                }
            }
        }
    }
}
