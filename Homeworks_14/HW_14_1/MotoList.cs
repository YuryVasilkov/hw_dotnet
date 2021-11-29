using System;
using System.Collections.Generic;

namespace HW_14_1
{
    class MotoList : IRepository<Motorcycle>
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

        public void Create(Motorcycle moto)
        {
            motoList.Add(moto);
        }

        public void DeleteByID(int id)
        {
            for (int i = 0; i < motoList.Count; i++)
            {
                if (motoList[i].ID == id)
                {
                    motoList.Remove(motoList[i]);
                    break;
                }
            }
        }

        public void DeleteByName(string name)
        {
            for (int i = 0; i < motoList.Count; i++)
            {
                if (motoList[i].Name.Equals(name))
                {
                    motoList.Remove(motoList[i]);
                }
            }
        }

        public Motorcycle[] GetAll()
        {
            return motoList.ToArray();
        }

        public Motorcycle GetByID(int id)
        {
            for (int i = 0; i < motoList.Count; i++)
            {
                if (motoList[i].ID == id)
                {
                    return motoList[i];
                }
            }
            return null;
        }

        public void UpdateByID(int id)
        {
            string input;
            int inputNumber = 0;

            for (int i = 0; i < motoList.Count; i++)
            {
                if (motoList[i].ID == id)
                {
                    Console.WriteLine("Совпадение найдено!");
                    Console.WriteLine("Введите новое имя или нажмите enter");
                    input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        motoList[i].Name = input;
                    }

                    Console.WriteLine("Введите новую модель или нажмите enter");
                    input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        motoList[i].Model = input;
                    }

                    Console.WriteLine("Введите новый год выпуска или нажмите enter");
                    input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out inputNumber))
                    {
                        motoList[i].Year = inputNumber;
                    }

                    Console.WriteLine("Введите новый пробег или нажмите enter");
                    input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out inputNumber))
                    {
                        motoList[i].Odometer = inputNumber;
                    }
                }
            }
        }
    }
}