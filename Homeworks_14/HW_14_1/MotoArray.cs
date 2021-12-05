using System;
using System.Collections.Generic;

namespace HW_14_1
{
    class MotoArray : IRepository<Motorcycle>
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

        public void Create(Motorcycle moto)
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

        public void DeleteByName(string name)
        {
            for (int i = 0; i < motoArray.Length; i++)
            {
                if (motoArray[i] != null && motoArray[i].Name.Equals(name))
                {
                    motoArray[i] = null;
                }
            }
        }

        public void DeleteByID(int id)
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

        public Motorcycle GetByID(int id)
        {
            for (int i = 0; i < motoArray.Length; i++)
            {
                if (motoArray[i] != null && motoArray[i].ID == id)
                {                    
                    return motoArray[i];
                }
            }
            return null;
        }

        public Motorcycle[] GetAll()
        {
            List<Motorcycle> list = new();
            for (int i = 0; i < motoArray.Length; i++)
            {
                if (motoArray[i] != null)
                {
                    list.Add(motoArray[i]);
                }
            }
            return list.ToArray();
        }

        public void UpdateByID(int id)
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