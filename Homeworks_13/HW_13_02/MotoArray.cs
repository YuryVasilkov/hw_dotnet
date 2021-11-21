using System;

namespace HW_13_02
{
    class MotoArray : IMotorcycleRepository<Motorcycle>
    {
        private readonly Motorcycle[] motoArray = new Motorcycle[20];
        public MotoArray()
        {
            motoArray[0] = new(1, "Honda", "CB-1000", 2020, 10);
            motoArray[1] = null;
            motoArray[2] = new(2, "Yamaha", " V-Max", 2019, 220);
            motoArray[3] = new(3, "Suzuki", " RF40RV", 2018, 500);
            motoArray[4] = new(4, "BMW", " k1200s", 2021, 0);
            motoArray[5] = new(5, "Kawasaki", " Eliminator-400", 2020, 100);
        }
        private static void OutputToConsole(Motorcycle moto)
        {
            Console.WriteLine($"Guid: {moto.Guid}.\n Id: {moto.ID}.\n Name: {moto.Name} -{moto.Model}. \n Year of issue: {moto.Year}. \n Odometer: {moto.Odometer} km.");
            Console.WriteLine();
        }

        public void CreateMotorcycle(Motorcycle moto)
        {
            for (int i = 0; i < motoArray.Length; i++)
            {
                if (motoArray[i] is null)
                {
                    motoArray[i] = moto;
                    break;
                }
            }
        }

        public void DeleteMotorcycleByName(string name)
        {
            for (int i = 0; i < motoArray.Length; i++)
            {
                if (motoArray[i] != null && motoArray[i].Name.Equals(name))
                {
                    motoArray[i] = null;
                }
            }
        }

        public void DeleteMotorcycleByID(int id)
        {
            for (int i = 0; i < motoArray.Length; i++)
            {
                if (motoArray[i] != null && motoArray[i].ID == id)
                {
                    motoArray[i] = null;
                    break;
                }
            }
        }

        public void GetMotorcycleByID(int id)
        {
            for (int i = 0; i < motoArray.Length; i++)
            {
                if (motoArray[i] != null && motoArray[i].ID == id)
                {
                    OutputToConsole(motoArray[i]);
                    break;
                }
            }
        }

        public void GetAllMotorcycles()
        {
            for (int i = 0; i < motoArray.Length; i++)
            {
                if (motoArray[i] != null)
                {
                    OutputToConsole(motoArray[i]);
                }
            }
        }

        public void UpdateMotorcycleByID(int id)
        {
            string input;
            int inputNumber = 0;

            for (int i = 0; i < motoArray.Length; i++)
            {
                if (motoArray[i] != null && motoArray[i].ID == id)
                {
                    Console.WriteLine("Совпадение найдено!");
                    Console.WriteLine("Введите новое имя или нажмите enter");
                    input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        motoArray[i].Name = input;
                    }

                    Console.WriteLine("Введите новую модель или нажмите enter");
                    input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        motoArray[i].Model = input;
                    }

                    Console.WriteLine("Введите новый год выпуска или нажмите enter");
                    input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out inputNumber))
                    {
                        motoArray[i].Year = inputNumber;
                    }

                    Console.WriteLine("Введите новый пробег или нажмите enter");
                    input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out inputNumber))
                    {
                        motoArray[i].Odometer = inputNumber;
                    }
                }
            }
        }
    }
}