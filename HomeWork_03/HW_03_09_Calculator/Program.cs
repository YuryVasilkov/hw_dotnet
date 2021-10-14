using System;

namespace HW_03_09_Calculator
{
    static class Calculator
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Mul(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double? Div(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                return null;
            }
        }

        public static double Rem(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                return num1;
            }
        }

        public static double Square(double num)
        {
            return Math.PI * num * num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter first number for addition");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter second number for addition");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter first number for subtraction");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter second number for subtraction");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter first number for multiplication");
            double num5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter second number for multiplication");
            double num6 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter first number for division");
            double num7 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter second number for division");
            double num8 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter first number for find the remainder of the division");
            double num9 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter second number for find the remainder of the division");
            double num10 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter number for find the area of a circle");
            double num11 = double.Parse(Console.ReadLine());

            Console.WriteLine("{1} + {2} = {0}", Calculator.Add(num1, num2), num1, num2);
            Console.WriteLine("{1} - {2} = {0}", Calculator.Sub(num3, num4), num3, num4);
            Console.WriteLine("{1} * {2} = {0}", Calculator.Mul(num5, num6), num5, num6);

            if (num8 == 0)
            {
                Console.WriteLine("Error! You cannot divide by zero");
            }
            else
            {
                Console.WriteLine("{1} / {2} = {0}", Calculator.Div(num7, num8), num7, num8);
            }

            Console.WriteLine("{1} % {2} = {0}", Calculator.Rem(num9, num10), num9, num10);
            Console.WriteLine("The area of a circle = {0}", Calculator.Square(num11));

        }
    }
}
