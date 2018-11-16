using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var values = input.Split(' ');

            var calculatorStack = new Stack<string>(values.Reverse());

            while (calculatorStack.Count > 1)
            {
                int firstOperand = Int32.Parse(calculatorStack.Pop());
                string operand = calculatorStack.Pop();
                int secondOperand = Int32.Parse(calculatorStack.Pop());

                switch (operand)
                {
                    case "+":
                        calculatorStack.Push((firstOperand + secondOperand).ToString());
                        break;
                    case "-":
                        calculatorStack.Push((firstOperand - secondOperand).ToString());

                        break;
                    default:
                        Console.WriteLine("Only + and - operations supported.");
                        break;
                }
            }

            Console.WriteLine(calculatorStack.Peek());

            


            Console.ReadKey();
        }
    }
}
