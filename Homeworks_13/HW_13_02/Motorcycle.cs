using System;

namespace HW_13_02
{
    class Motorcycle
    {
        public Guid Guid { get; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }

        public Motorcycle()
        {

        }
        public Motorcycle(int id, string name, string model, int year, int odometer)
        {
            Guid = Guid.NewGuid();
            ID = id;
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
    }
}