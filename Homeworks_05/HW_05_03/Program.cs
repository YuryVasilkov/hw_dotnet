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

            /* CODE FOR ADDITIONAL TASK
             * The built-in Reverse() method is about 5 times better than the one implemented by hand
              
              
            Random rand = new Random();
            Stopwatch timer = new Stopwatch();
            int[] testArray = new int[100_000_000];

            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = rand.Next(1, 1000);
            }

            Console.WriteLine(new string('*',30));
            

            timer.Start();
            for (int i = 0; i < testArray.Length / 2; i++)
            {
                temp = testArray[i];
                testArray[i] = testArray[testArray.Length - 1 - i];
                testArray[testArray.Length - 1 - i] = temp;
            }
            timer.Stop();
            
            Console.WriteLine($"Time:{timer.ElapsedMilliseconds}");

            timer.Reset();
            timer.Start();
            Array.Reverse(testArray);
            timer.Stop();

            Console.WriteLine($"Time for Reverse method:{timer.ElapsedMilliseconds}");

            */
        }
    }
}
