using System;
using System.Threading;

namespace HW_14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueDateTime queue1 = new();
            queue1.Enqueue(DateTime.Now);
            Thread.Sleep(5000);
            queue1.Enqueue(DateTime.Now);
            Thread.Sleep(5000);
            queue1.Enqueue(DateTime.Now);
            queue1.ShowAll();
            Console.WriteLine(new string('*',30));
            Console.WriteLine(queue1.Peek());
            queue1.Dequeue();
            Console.WriteLine(new string('*', 30));
            queue1.ShowAll();

            Console.WriteLine(new string('*', 30));

            QueueClass<string> queue2 = new();
            queue2.Enqueue("Hi");
            queue2.Enqueue("Everyone");
            queue2.Enqueue("!");
            queue2.ShowAll();
            Console.WriteLine(new string('*', 30));
            Console.WriteLine(queue2.Peek());
            queue2.Dequeue();
            Console.WriteLine(new string('*', 30));
            queue2.ShowAll();
        }
    }
}