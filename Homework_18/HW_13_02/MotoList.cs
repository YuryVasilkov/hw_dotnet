using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_13_02
{
    class MotoList : IMotorcycleRepository<Motorcycle>
    {
        readonly List<Motorcycle> motoList = new();

        public MotoList()
        {
            motoList.Add(new(1, "Honda", "CB-1", 2020, 0));
            motoList.Add(new(2, "Yamaha", " XJR1200", 2018, 320));
            motoList.Add(new(3, "Suzuki", " Bandit400", 2019, 400));
            motoList.Add(new(4, "BMW", " F800ST", 2021, 90));
            motoList.Add(new(5, "Kawasaki", " Eliminator", 2020, 1000));
        }

        private static void OutputToConsole(Motorcycle moto)
        {
            Console.WriteLine($"Guid: {moto.Guid}.\n Id: {moto.ID}.\n Name: {moto.Name} -{moto.Model}. \n Year of issue: {moto.Year}. \n Odometer: {moto.Odometer} km.");
            Console.WriteLine();
        }

        public void CreateMotorcycle(Motorcycle moto)
        {
            motoList.Add(moto);
        }

        public void DeleteMotorcycleByID(int id)
        {
            var result = motoList.First(_ => _.ID == id);
            motoList.Remove(result);
        }

        public void DeleteMotorcycleByName(string name)
        {
            var result = motoList.First(_ => _.Name == name);
            motoList.Remove(result);
        }

        public void GetAllMotorcycles()
        {
            for (int i = 0; i < motoList.Count; i++)
            {
                OutputToConsole(motoList[i]);
            }
        }

        public void GetMotorcycleByID(int id)
        {
            var result = motoList.First(_ => _.ID == id);
            OutputToConsole(result);
        }

        public void UpdateMotorcycleByID(int id)
        {
            string input;
            int inputNumber = 0;

            var result = motoList.FirstOrDefault(_ => _.ID == id);
            if (result != null)
            {
                Console.WriteLine("Совпадение найдено!");
                Console.WriteLine("Введите новое имя или нажмите enter");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    result.Name = input;
                }

                Console.WriteLine("Введите новую модель или нажмите enter");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    result.Model = input;
                }

                Console.WriteLine("Введите новый год выпуска или нажмите enter");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out inputNumber))
                {
                    result.Year = inputNumber;
                }

                Console.WriteLine("Введите новый пробег или нажмите enter");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out inputNumber))
                {
                    result.Odometer = inputNumber;
                }
            }
        }
    }
}