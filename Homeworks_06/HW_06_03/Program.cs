using System;
using System.Text;

namespace HW_06_03
{
    class Program
    {
        static void Main(string[] args)
        {
            void Calculate(char sign, double num1, double num2)
            {
                if (sign != default)
                {
                    switch (sign)
                    {
                        case '+':
                            {
                                Console.WriteLine($"{num1} + {num2} =  {num1 + num2}");
                                break;
                            }
                        case '-':
                            {
                                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                                break;
                            }
                        case '*':
                            {
                                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                                break;
                            }
                        case '/':
                            {
                                if (num2 != 0)
                                {
                                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                                }
                                else
                                {
                                    Console.WriteLine("You cannot divide by zero!");
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong symbol.");
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Operation symbol not found");
                }
            }

            string text = "gdfgdf234dg54gf/23oP42";
            StringBuilder result = new();
            bool isSign;
            bool flag = default;
            double num1 = 0;
            double num2 = 0;
            char sign = default;

            for (int i = 0; i < text.Length; i++)
            {
                isSign = text[i] == '+' || text[i] == '-' || text[i] == '*' || text[i] == '/';
                if (char.IsDigit(text[i]) && !flag)
                {
                    result.Append(text[i]);
                }

                if (isSign && !flag)
                {
                    if (result.Length != 0)
                    {
                        num1 = Convert.ToDouble(result.ToString());
                        result.Clear();
                    }
                    sign = text[i];
                    flag = true;
                }

                if (char.IsDigit(text[i]) && flag)
                {
                    result.Append(text[i]);
                }
            }

            if (result.Length != 0)
            {
                num2 = Convert.ToDouble(result.ToString());
            }

            Calculate(sign, num1, num2);


        }
    }
}
