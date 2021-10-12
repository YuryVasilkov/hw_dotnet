﻿using System;

namespace HW_03_07_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int getBirthYear(string numberInString)
            {
                while ((!int.TryParse(numberInString, out int num)) || num > DateTime.Now.Year || num < 1)
                {
                    Console.WriteLine("Incorrect data. Please, try again");
                    numberInString = Console.ReadLine();
                }

                return Convert.ToInt32(numberInString);
            }

            int getCurrentYear(string numberInString, int yearOfBirth)
            {
                while ((!int.TryParse(numberInString, out int num)) || num > DateTime.Now.Year || yearOfBirth > num)
                {
                    Console.WriteLine("Incorrect data. Please, try again");
                    numberInString = Console.ReadLine();
                }

                return Convert.ToInt32(numberInString);
            }

            int getBirthMonth(string numberInString)
            {
                while ((!int.TryParse(numberInString, out int num)) || num > 12 || num < 1)
                {
                    Console.WriteLine("Incorrect data. Please, try again");
                    numberInString = Console.ReadLine();
                }

                return Convert.ToInt32(numberInString);
            }
            int getCurrentMonth(string numberInString, int yearOfBirth, int currentYear, int BirthMonth)
            {
                bool isSameYear = yearOfBirth == currentYear;

                while ((!int.TryParse(numberInString, out int num)) || num > 12 || num < 1 || (isSameYear && num < BirthMonth))
                {
                    Console.WriteLine("Incorrect data. Please, try again");
                    numberInString = Console.ReadLine();
                }

                return Convert.ToInt32(numberInString);
            }
            Console.WriteLine("Please, enter the year of birth");
            string inputData = Console.ReadLine();
            int yearOfBirth = getBirthYear(inputData);
            Console.WriteLine("Please, enter the number of the month of birth");
            inputData = Console.ReadLine();
            int monthOfBirth = getBirthMonth(inputData);
            Console.WriteLine("Please, enter the current year");
            inputData = Console.ReadLine();
            int currentYear = getCurrentYear(inputData, yearOfBirth);
            Console.WriteLine("Please, enter the number of the current month");
            inputData = Console.ReadLine();
            int currentMonth = getCurrentMonth(inputData, yearOfBirth, currentYear, monthOfBirth);
            if (currentMonth >= monthOfBirth)
            {
                Console.WriteLine(" Your age is {0}", currentYear-yearOfBirth);
            }
            else
            {
                Console.WriteLine(" Your age is {0}", currentYear - yearOfBirth - 1);
            }
        }
    }
}
