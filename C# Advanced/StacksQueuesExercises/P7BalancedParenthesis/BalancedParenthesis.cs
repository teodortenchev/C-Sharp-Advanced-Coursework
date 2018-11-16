using System;
using System.Linq;
using System.Collections.Generic;

namespace P7BalancedParenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            string parenthesis = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            char[] openParanthesis = new char[] { '(', '{', '[' };
            char[] closingParanthesis = new char[] { ')', '}', ']' };
            bool isValid = true;

            for (int i = 0; i < parenthesis.Length; i++)
            {
                char currentBracket = parenthesis[i];

                if (openParanthesis.Contains(currentBracket))
                {
                    stack.Push(currentBracket);

                }

                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }
                else
                {
                    if (stack.Peek() == '(' && currentBracket == ')')
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '[' && currentBracket == ']')
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '{' && currentBracket == '}')
                    {
                        stack.Pop();
                    }
                }
            }

            if (stack.Count == 0 && isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
