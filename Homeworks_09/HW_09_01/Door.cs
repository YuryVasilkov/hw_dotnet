using System;

namespace HW_09_01
{
    class Door
    {
        public string Color { get; set; }
        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {Color}." );
        }
    }
}