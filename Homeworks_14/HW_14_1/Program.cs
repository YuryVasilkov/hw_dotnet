using System;

namespace HW_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MotoArray array = new();
            MotoList list = new();

            array.UpdateByID(3);
            var result = array.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('*', 60));

            list.GetByID(4);
            list.Create(new Motorcycle(6, "Honda", "ViperSport", 2015, 5000));
            result = list.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}