using System;
using System.Collections.Generic;

namespace HW_14_2
{
    class QueueDateTime
    {
        readonly List<DateTime> queue = new();

        public void Enqueue(DateTime date)
        {
            queue.Add(date);
        }

        public DateTime Dequeue()
        {
            if (queue.Count != 0)
            {
                DateTime element = queue[0];
                queue.RemoveAt(0);
                return element;
            }
            return default;
        }

        public DateTime Peek()
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
                Console.WriteLine(item);
            }
        }
    }
}