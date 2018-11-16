using System;
using System.Collections.Generic;

namespace P9SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string text = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                byte command = byte.Parse(tokens[0]);

                if (command == 1)
                {
                    string currentText = tokens[1];
                    stack.Push(text);
                    text += currentText;
                }
                else if (command == 2)
                {
                    int deletionCount = int.Parse(tokens[1]);
                    stack.Push(text);
                    if (text.Length >= deletionCount)
                    {
                        text = text.Substring(0, text.Length - deletionCount);
                    }
                }
                else if (command == 3)
                {
                    int index = int.Parse(tokens[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command == 4)
                {
                    if (stack.Count > 0)
                    {
                        text = stack.Pop();
                    }
                }
               


            }
        }
    }
}
