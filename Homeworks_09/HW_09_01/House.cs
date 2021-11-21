using System;

namespace HW_09_01
{
    class House
    {
        public static int Area { get; set; }
        public static string Color { get; set; }

        public House()
        {
            Area = 100;
            Color = "Default-white";
        }
        public House(int area, string color)
        {
            Area = area;
            Color = color;            
        }
        
        public class SmallApartment : House
        {
            public SmallApartment()
            {
                Color = "Default-white";
            }
            public SmallApartment(string color)
            {
                Area = 50;
                Color = color;
            }
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {Area} m2.");
        }
        public Door GetDoor()
        {
            Door _myDoor = new();
            _myDoor.Color = Color;
            return _myDoor;
        } 
    }
}