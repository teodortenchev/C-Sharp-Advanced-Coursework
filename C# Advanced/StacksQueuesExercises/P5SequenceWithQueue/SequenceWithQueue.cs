using System;
using System.Collections.Generic;
using System.Linq;

namespace P5SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            long inputNumber = long.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            List<long> sequenceResults = new List<long>() { inputNumber };
            queue.Enqueue(inputNumber);
            for (int i = 0; i < 20; i++)
            {
                long currentNumber = queue.Dequeue();

                long a = currentNumber + 1;
                long b = 2 * currentNumber + 1;
                long c = currentNumber + 2;
                sequenceResults.Add(a);
                sequenceResults.Add(b);
                sequenceResults.Add(c);
                queue.Enqueue(a);
                queue.Enqueue(b);
                queue.Enqueue(c);

            }

            Console.WriteLine(String.Join(" ", sequenceResults.Take(50)));
            
        }
    }
}
