using System;
using System.Linq;
using System.Collections.Generic;

namespace P4BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int toEnqueue = tokens[0];
            int toDequeue = tokens[1];
            int toFind = tokens[2];

            //var queue = new Queue<int>(numbers);
            var queue = new Queue<int>(toEnqueue);

            for (int i = 0; i < toEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            if (toDequeue <= queue.Count)
            {
                for (int i = 0; i < toDequeue; i++)
                {
                    queue.Dequeue();
                }
            }

            if (queue.Contains(toFind))
            {
                Console.WriteLine("true");
            } else
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.ToArray().Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
            
        }
    }
}
