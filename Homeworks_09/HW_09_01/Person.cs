using System;

namespace HW_09_01
{
    class Person
    {
        private readonly House _myHouse;
        private readonly string _myName;

        public Person()
        {

        }
        public Person(House house, string name)
        {
            this._myHouse = house;
            this._myName = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"My name is {_myName}.");
            _myHouse.ShowData();
            _myHouse.GetDoor().ShowData();            
        }
    }
}