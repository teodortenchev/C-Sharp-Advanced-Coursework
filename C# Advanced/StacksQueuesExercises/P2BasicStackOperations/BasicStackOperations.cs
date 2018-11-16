using System;
using System.Collections.Generic;
using System.Linq;

namespace P2BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int toPush = tokens[0];
            int toPop = tokens[1];
            int toFind = tokens[2];

            int[] integers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < toPush; i++)
            {
                stack.Push(integers[i]);
            }

            for (int i = 0; i < toPop; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            if (stack.Contains(toFind))
            {
                Console.WriteLine("true");
            } else
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.ToArray().Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }

        }
    }
}
