using System;

namespace HW_09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            House.SmallApartment apartment = new("black");
            Person iAm = new(apartment, "Yury Vasilkov");
            iAm.ShowData();

            Console.WriteLine(new string ('*',50));

            House apart2 = new(121, "brown");
            Person myMother = new(apart2, "Elena Vasilkova");
            myMother.ShowData();
        }
    }
}