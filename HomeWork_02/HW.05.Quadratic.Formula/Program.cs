using System;

namespace HW._05.Quadratic.Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Please, input a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, input b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, input c");
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0 && b == 0)
            {
                Console.WriteLine("This is not an equation. Please, try again...");
            }
            else if (a == 0)
            {
                Console.WriteLine("Equation root is {0}", -c / b);
            }
            else
            {
               double d = b * b - 4 * a * c;
                if (d > 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("Equation roots is {0} and {1}", x1, x2);
                }
                else if (d == 0)
                {
                    Console.WriteLine("Equation root is {0}", (-b / (2*a)));
                }
                else
                {
                    Console.WriteLine("Equation has no roots");
                }
            }
            
        }
    }
}
