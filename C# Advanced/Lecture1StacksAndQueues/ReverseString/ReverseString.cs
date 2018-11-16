using System;
using System.Collections.Generic;
namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Stack<char> stringReverser = new Stack<char>();
            string input = Console.ReadLine();

            foreach (char letter in input)
            {
                stringReverser.Push(letter);
            }

            while (stringReverser.Count > 0)
            {
                Console.Write(stringReverser.Pop());
            }

            Console.ReadKey();

        }
    }
}
