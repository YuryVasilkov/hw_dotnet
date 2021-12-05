using System;
using System.Collections.Generic;

namespace HW_14_2
{
    class QueueClass<T> where T:class
    {
        readonly List<T> queue = new();

        public void Enqueue(T element)
        {
            queue.Add(element);
        }

        public T Dequeue()
        {
            if (queue.Count != 0)
            {
                T element = queue[0];
                queue.RemoveAt(0);
                return element;
            }
            return default;
        }

        public T Peek()
        {
            if (queue.Count != 0)
            {
                return queue[0];
            }
            return default;
        }

        public void ShowAll()
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}