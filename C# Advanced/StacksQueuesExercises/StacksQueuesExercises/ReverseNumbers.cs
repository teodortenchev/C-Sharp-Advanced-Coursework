using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksQueuesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

            var stack = new Stack<int>();
            foreach (var item in input)
            {
                stack.Push(item);
            }
            
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }
            //Join elements of an array
            //String.Join(" ", strings));

        }
    }
}
