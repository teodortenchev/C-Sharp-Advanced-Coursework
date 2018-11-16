using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            string mathExpression = Console.ReadLine();
            Stack<int> bracketFinder = new Stack<int>(mathExpression.Length);

            for (int i = 0; i < mathExpression.Length; i++)
            {
                if (mathExpression[i] == ' ')
                {
                    i++;
                    
                }
                if (mathExpression[i] == '(')
                {
                    bracketFinder.Push(i);
                }
                if (mathExpression[i] == ')')
                {
                    int startIndex = bracketFinder.Pop();
                    string found = mathExpression.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(found);
                      
                }
            }
        }
    }
}
