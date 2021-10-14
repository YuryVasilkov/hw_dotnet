using System;

namespace HW._05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int AddNumber()
            {
                string num1 = Console.ReadLine();

                while (!int.TryParse(num1, out int num) || num <= 0 || num > 100)
                {
                    Console.WriteLine("Incorrect data. Please, try again");
                    num1 = Console.ReadLine();
                }

                return Convert.ToInt32(num1);
            }

            Console.WriteLine("Please, input a number from 1 to 100");
            int number = AddNumber();
            int printNumber = 1;

            Console.WriteLine();

            for (int i = number - 1; i >= 0; i--)
            {
                if (printNumber >= 10)
                {
                    printNumber %= 10;
                }

                for (int j = 1; j < number - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = number - i; k <= number; k++)
                {
                    Console.Write(" ");
                    Console.Write(printNumber);
                }

                printNumber++;
                Console.WriteLine();
            }
        }
    }
}
