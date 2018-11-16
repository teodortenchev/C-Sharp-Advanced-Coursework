using System;
using System.Collections.Generic;

namespace ExamPreparation1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lockes = { 15, 13, 16 };
            Stack<int> locks = new Stack<int>(lockes);

            foreach (var item in locks)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine(locks.Peek());

            Console.WriteLine("Queue:");
            Queue<int> queue = new Queue<int>(lockes);

            Console.WriteLine(queue.Peek());
        }
    }
}
