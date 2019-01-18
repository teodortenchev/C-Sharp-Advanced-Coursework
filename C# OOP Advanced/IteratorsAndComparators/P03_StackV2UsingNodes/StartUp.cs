using System;
using System.Linq;

namespace P03_StackV2UsingNodes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1).ToArray();

            Stack<string> stack = new Stack<string>();

            foreach (var item in data)
            {
                stack.Push(item);
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                switch (command)
                {
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:

                        string element = command.Split()[1];
                        stack.Push(element);
                        break;
                }

                command = Console.ReadLine();

            }

                Console.WriteLine(string.Join(Environment.NewLine, stack));
                Console.WriteLine(string.Join(Environment.NewLine, stack));

        }
    }
}
