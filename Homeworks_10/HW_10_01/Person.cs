using System;

namespace HW_10_01
{
    class Person
    {
        public int Age { get; set; }
        
        public void SetAge(int n)
        {
            Age = n;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}