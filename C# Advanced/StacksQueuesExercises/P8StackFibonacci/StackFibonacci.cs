using System;
using System.Collections.Generic;

namespace P8StackFibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Stack<long> fibonacciSequence = new Stack<long>();
            
            
            fibonacciSequence.Push(0);
            fibonacciSequence.Push(1);
            // 0 1  - Stack is LIFO
            for (int i = 0; i < n - 1; i++)
            {
                long t1 = fibonacciSequence.Pop();
                long t2 = fibonacciSequence.Peek();
                fibonacciSequence.Push(t1);
                fibonacciSequence.Push(t1 + t2);
                
            }

            Console.WriteLine(fibonacciSequence.Pop());
        }
    }
}
