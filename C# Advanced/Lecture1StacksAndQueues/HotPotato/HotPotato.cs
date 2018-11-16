using System;
using System.Collections.Generic;

namespace HotPotato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split(' ');
            int number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);

            while (queue.Count > 1)
            {
                for (int i = 1; i < number; i++)  
                {
                    queue.Enqueue(queue.Dequeue());
                }
                string removedKid = queue.Dequeue();
                Console.WriteLine($"Removed {removedKid}");
            }
            string lastKid = queue.Dequeue();
            Console.WriteLine($"Last is {lastKid}");
        }
    }
}
