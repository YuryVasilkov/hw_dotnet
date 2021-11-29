using System;
using System.Collections.Generic;

namespace HW_14_2
{
    class QueueObject
    {
        readonly List<object> queue = new();

        public void Enqueue(object element)
        {
            queue.Add(element);
        }

        public object Dequeue()
        {
            if (queue.Count != 0)
            {
                object element = queue[0];
                queue.RemoveAt(0);
                return element;
            }
            return default;
        }

        public object Peek()
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