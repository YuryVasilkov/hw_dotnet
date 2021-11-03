using System;

namespace HW_08_02_01_AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle justMoto = new();
            SportBike hondaMoto = new();

            //CONST
            Console.WriteLine(Motorcycle.speedPublic);
            Console.WriteLine(SportBike.speedPublic);
            //Console.WriteLine(Motorcycle.speedProtected);  доступ только в классе и наследниках
            //Console.WriteLine(SportBike.speedProtected); доступ только в классе и наследниках
            Console.WriteLine(Motorcycle.speedInternal);
            Console.WriteLine(SportBike.speedInternal);
            Console.WriteLine(Motorcycle.speedProtectedInternal);
            Console.WriteLine(SportBike.speedProtectedInternal);
            // Console.WriteLine(Motorcycle.speedPrivate); доступ только в самом классе
            // Console.WriteLine(SportBike.speedPrivate); доступ только в самом классе
            // Console.WriteLine(Motorcycle.speedProtectedPrivate); доступ либо в классе, либо в наследнике в этой сборке
            // Console.WriteLine(SportBike.speedProtectedPrivate); доступ либо в классе, либо в наследнике в этой сборке

            //Поля
            Console.WriteLine(justMoto.namePublic);
            Console.WriteLine(hondaMoto.namePublic);
            // Console.WriteLine(justMoto.nameProtected); доступ только в классе и наследниках
            // Console.WriteLine(hondaMoto.nameProtected); доступ только в классе и наследниках
            Console.WriteLine(justMoto.nameInternal);
            Console.WriteLine(hondaMoto.nameInternal);
            Console.WriteLine(justMoto.nameProtectedInternal);
            Console.WriteLine(hondaMoto.nameProtectedInternal);
            // Console.WriteLine(justMoto.namePrivate); доступ только в самом классе
            // Console.WriteLine(hondaMoto.namePrivate); доступ только в самом классе
            // Console.WriteLine(justMoto.nameProtectedPrivate); доступ либо в классе, либо в наследнике в этой сборке
            // Console.WriteLine(hondaMoto.nameProtectedPrivate); //доступ либо в классе, либо в наследнике в этой сборке

            //Свойства
            justMoto.NamePublic = "123";
            hondaMoto.NamePublic = "113";
            //justMoto.NameProtected = "123"; доступ только в классе и наследниках
            //hondaMoto.NameProtected = "113"; доступ только в классе и наследниках
            justMoto.NameInternal = "123";
            hondaMoto.NameInternal = "113";
            justMoto.NameProtectedInternal = "123";
            hondaMoto.NameProtectedInternal = "113";
            //justMoto.NamePrivate = "123"; доступ только в самом классе
            //hondaMoto.NamePrivate = "113"; доступ только в самом классе
            // Console.WriteLine(justMoto.NameProtectedPrivate); доступ либо в классе, либо в наследнике в этой сборке
            // Console.WriteLine(hondaMoto.NameProtectedPrivate); доступ либо в классе, либо в наследнике в этой сборке

            //Методы
            justMoto.PublicStartEngine();
            hondaMoto.PublicStartEngine();
            //justMoto.ProtectedStartEngine(); доступ только в классе и наследниках
            //hondaMoto.ProtectedStartEngine(); доступ только в классе и наследниках
            justMoto.InternalStartEngine();
            hondaMoto.InternalStartEngine();
            justMoto.ProtectedInternalStartEngine();
            hondaMoto.ProtectedInternalStartEngine();
            //justMoto.PrivateStartEngine(); доступ только в самом классе
            //hondaMoto.PrivateStartEngine(); доступ только в самом классе
            //justMoto.ProtectedPrivateStartEngine(); доступ либо в классе, либо в наследнике в этой сборке
            //hondaMoto.ProtectedPrivateStartEngine(); доступ либо в классе, либо в наследнике в этой сборке
        }
    }
}