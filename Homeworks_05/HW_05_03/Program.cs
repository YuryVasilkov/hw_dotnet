using System;
using System.Diagnostics;

namespace HW_05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintArray(int[] array)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int temp;

            Console.WriteLine("Source array:");
            PrintArray(numbers);

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            Console.WriteLine("The resulting array");
            PrintArray(numbers);
        }
    }
}
