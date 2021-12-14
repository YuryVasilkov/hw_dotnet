using System;
using System.Linq;

namespace _07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = new int[133];
            Random generator = new();

            Console.WriteLine("Current array:");
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = generator.Next(1, 100);
                Console.Write(randomNumbers[i] + " ");
            }

            Console.WriteLine();
            var maxElement = randomNumbers.Max();
            int index = Array.IndexOf(randomNumbers, maxElement);

            Console.WriteLine($"Max element is {maxElement}. Its position is {index}");


        }
    }
}
