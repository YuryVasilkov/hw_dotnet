using System;

namespace HW._05.GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHour = DateTime.Now.Hour;
            switch (currentHour)
            {
                case int hours when (hours >= 9 && hours < 12):
                    {
                        Console.WriteLine("Good morning, guys!");
                        break;
                    }
                case int hours when (hours >= 12 && hours < 15):
                    {
                        Console.WriteLine("Good day, guys!");
                        break;
                    }
                case int hours when (hours >= 15 && hours < 22):
                    {
                        Console.WriteLine("Good evening, guys!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Good night, guys!");
                        break;
                    }
            }
        }
    }
}
