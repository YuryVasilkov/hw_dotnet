using System;

namespace HW_05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int AddNumber()
            {                
                string num1 = Console.ReadLine();

                while (!int.TryParse(num1, out int num))
                {
                    Console.WriteLine("Incorrect data. Please, try again");
                    num1 = Console.ReadLine();
                }

                return Convert.ToInt32(num1);
            }

            int AddPositionNumber(int[] array)
            {
                string num1 = Console.ReadLine();

                while (!int.TryParse(num1, out int num) || num <= 0 || num >= array.Length)
                {
                    Console.WriteLine("Incorrect data. Please, try again");
                    num1 = Console.ReadLine();
                }

                return Convert.ToInt32(num1);
            }

            void PrintArray(int[] array)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            int[] numbers = new int[10];
            int position, additionalNumber;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.WriteLine($"Please, input number № {i + 1}");
                numbers[i] = AddNumber();
            
            }

            Console.WriteLine("Current array:");
            PrintArray(numbers);

            Console.WriteLine("Please, input additional number.");
            additionalNumber = AddNumber();

            Console.WriteLine("Please, input the position number of additional number.");
            position = AddPositionNumber(numbers);

            for (int i = numbers.Length - 1; i > position; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            numbers[position] = additionalNumber;

            Console.WriteLine("Array after shift:");
            PrintArray(numbers);
        }
    }
}
