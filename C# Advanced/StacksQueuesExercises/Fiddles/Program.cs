using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiddles
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abc";
            Stack<char> stack = new Stack<char>();

            foreach (var character in text)
            {
                stack.Push(character);
            }
            stack.Pop();

            Console.WriteLine(String.Join("",stack.ToArray().Reverse()));
        }
    }
}
