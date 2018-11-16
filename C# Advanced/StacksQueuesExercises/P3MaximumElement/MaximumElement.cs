using System;
using System.Collections.Generic;
using System.Linq;

namespace P3MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int queriesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < queriesCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                byte command = byte.Parse(tokens[0]);

                //1 is Push the element into the stack; 2 = Delete the element from top of stack; 3 = Print the maximum
                switch (command)
                {
                    case 1:
                        byte number = byte.Parse(tokens[1]);
                        stack.Push(number);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.ToArray().Max());
                        }
                        break;
                    default:
                        break;

                }


            }
        }
    }
}
