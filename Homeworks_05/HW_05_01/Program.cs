using System;

namespace HW_05_01
{
    class Program
    {

        static void Main(string[] args)
        {

            int AddNumber(int number)
            {
                Console.WriteLine($"Please, input number № {++number}");
                string num1 = Console.ReadLine();

                while (!int.TryParse(num1, out int num))
                {
                    Console.WriteLine("Incorrect data. Please, try again");
                    num1 = Console.ReadLine();
                }

                return Convert.ToInt32(num1);
            }

            void PrintArray(int[] array, string name)
            {
                Console.WriteLine(name);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }

            Random generator = new Random();
            int[] randomNumbers = new int[10];
            int[] userNumbers = new int[10];
            int[] sumOfTwoArrays = new int[10];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = generator.Next(1, 5000);
                userNumbers[i] = AddNumber(i);
                sumOfTwoArrays[i] = randomNumbers[i] + userNumbers[i];
            }

            PrintArray(randomNumbers, "Array with random numbers:");
            PrintArray(userNumbers, "Array with user's numbers:");
            PrintArray(sumOfTwoArrays, "Summing Array:");
        }
    }
}
