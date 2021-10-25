﻿using System;

namespace HW_06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintArray(string[] array)
            {
                Console.WriteLine();
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Please,input a poem using ; as line separator");
            string poem = Console.ReadLine();
            Console.Clear();

            // poem for test
            // 10 программистов продукт решили сделать; Один спросил: "А деньги где?", — и их осталось 9; 9 программистов предстали перед боссом,; Один из них не знал FoxPro, и их осталось 8.; 8 программистов купили IBM,; Один сказал: "Мак лучше!", — и их осталось 7; 7 программистов хотели help прочесть,; У одного накрылся винт, и их осталось 6.; 6 программистов пытались код понять,; Один из них сошел с ума, и их осталось 5.; 5 программистов купили CD - ROM,; Один принес китайский диск — остались вчетвером.; 4 программиста работали на Си,; Один из них хвалил Паскаль, и их осталось 3.; 3 программиста в сети играли в DOOM,; Один чуть - чуть замешкался, и счет стал равен двум.; 2 программиста набрали дружно: "win".; Один устал загрузки ждать — остался лишь 1.; 1 программист все взял под свой контроль,; Но встретился с заказчиком, и их осталось 0.; 0 программистов ругал сердитый шеф,; Потом уволил одного, и стало их FF.

            string[] splitLines = poem.Split(';', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("The poem before replace");
            PrintArray(splitLines);

            Console.WriteLine(new string('*',100));
            Console.WriteLine();

            splitLines = poem.Replace('о', 'а').Replace('О', 'А').Split(';', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("The poem after replace");
            PrintArray(splitLines);
        }
    }
}
