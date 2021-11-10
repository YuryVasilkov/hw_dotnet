using System;

namespace HW_10_01
{
    class Teacher : Person
    {
        private string subject;

        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }
}