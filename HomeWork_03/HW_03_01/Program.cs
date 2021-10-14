using System;

namespace HW_03_01
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int AddNumber(string number)
            {
                Console.WriteLine("Please, input {0} number", number);
                string num1 = Console.ReadLine();

                while (!int.TryParse(num1, out int num)) 
                {
                    Console.WriteLine("Incorrect data. Please, try again");
                    num1 = Console.ReadLine();                    
                }              
               
                return Convert.ToInt32(num1);
            }
            
            Console.WriteLine("First number + Second number = {0}", AddNumber("first") + AddNumber("second"));


        }
    }
}
