using System;
using System.Linq;

namespace P03_Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();

            string[] input = Console.ReadLine().Split(new char[] { ' ', ','}, 
                StringSplitOptions.RemoveEmptyEntries);
           
            while (input[0] != "END")
            {
                int[] numbers = input.Skip(1).Select(x => int.Parse(x)).ToArray();

                if(input[0] == "Push")
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        stack.Push(int.Parse(input[i]));
                    }
                }

                else if(input[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                input = Console.ReadLine().Split();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
