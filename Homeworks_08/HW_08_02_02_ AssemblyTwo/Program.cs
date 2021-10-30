using HW_08_02_01_AssemblyOne;
using System;

namespace HW_08_02_02__AssemblyTwo
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
            //Console.WriteLine(Motorcycle.speedInternal); доступ только в сборке, где описан
            //Console.WriteLine(SportBike.speedInternal); доступ только в сборке, где описан
            //Console.WriteLine(Motorcycle.speedProtectedInternal); доступ только в наследниках
            //Console.WriteLine(SportBike.speedProtectedInternal); доступ только в наследниках
            // Console.WriteLine(Motorcycle.speedPrivate); доступ только в самом классе
            // Console.WriteLine(SportBike.speedPrivate); доступ только в самом классе
            // Console.WriteLine(Motorcycle.speedProtectedPrivate); доступ либо в классе, либо в наследнике в этой сборке
            // Console.WriteLine(SportBike.speedProtectedPrivate); доступ либо в классе, либо в наследнике в этой сборке

            //Поля
            Console.WriteLine(justMoto.namePublic);
            Console.WriteLine(hondaMoto.namePublic);
            // Console.WriteLine(justMoto.nameProtected); доступ только в классе и наследниках
            // Console.WriteLine(hondaMoto.nameProtected); доступ только в классе и наследниках
            // Console.WriteLine(justMoto.nameInternal); доступ только в сборке, где описан
            // Console.WriteLine(hondaMoto.nameInternal); доступ только в сборке, где описан
            // Console.WriteLine(justMoto.nameProtectedInternal); доступ только в наследниках
            // Console.WriteLine(hondaMoto.nameProtectedInternal); доступ только в наследниках
            // Console.WriteLine(justMoto.namePrivate); доступ только в самом классе
            // Console.WriteLine(hondaMoto.namePrivate); доступ только в самом классе
            // Console.WriteLine(justMoto.nameProtectedPrivate); доступ либо в классе, либо в наследнике в этой сборке
            // Console.WriteLine(hondaMoto.nameProtectedPrivate); //доступ либо в классе, либо в наследнике в этой сборке

            //Свойства
            justMoto.NamePublic = "123";
            hondaMoto.NamePublic = "113";
            //justMoto.NameProtected = "123"; доступ только в классе и наследниках
            //hondaMoto.NameProtected = "113"; доступ только в классе и наследниках
            //justMoto.NameInternal = "123"; доступ только в сборке, где описан
            //hondaMoto.NameInternal = "113"; доступ только в сборке, где описан
            //justMoto.NameProtectedInternal = "123"; доступ только в наследниках
            //hondaMoto.NameProtectedInternal = "113"; доступ только в наследниках
            //justMoto.NamePrivate = "123"; доступ только в самом классе
            //hondaMoto.NamePrivate = "113"; доступ только в самом классе
            // Console.WriteLine(justMoto.NameProtectedPrivate); доступ либо в классе, либо в наследнике в этой сборке
            // Console.WriteLine(hondaMoto.NameProtectedPrivate); доступ либо в классе, либо в наследнике в этой сборке

            //Методы
            justMoto.PublicStartEngine();
            hondaMoto.PublicStartEngine();
            //justMoto.ProtectedStartEngine(); доступ только в классе и наследниках
            //hondaMoto.ProtectedStartEngine(); доступ только в классе и наследниках
            //justMoto.InternalStartEngine(); доступ только в сборке, где описан
            //hondaMoto.InternalStartEngine(); доступ только в сборке, где описан
            //justMoto.ProtectedInternalStartEngine(); доступ только в наследниках
            //hondaMoto.ProtectedInternalStartEngine(); доступ только в наследниках
            //justMoto.PrivateStartEngine(); доступ только в самом классе
            //hondaMoto.PrivateStartEngine(); доступ только в самом классе
            //justMoto.ProtectedPrivateStartEngine(); доступ либо в классе, либо в наследнике в этой сборке
            //hondaMoto.ProtectedPrivateStartEngine(); доступ либо в классе, либо в наследнике в этой сборке
        }
    }
}