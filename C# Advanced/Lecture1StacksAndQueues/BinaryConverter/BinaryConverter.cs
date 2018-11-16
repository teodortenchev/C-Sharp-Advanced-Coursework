using System;
using System.Collections.Generic;
namespace BinaryConverter
{
    class BinaryConverter
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());

            if (decimalNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            Stack<int> binaryConverter = new Stack<int>();

            while (decimalNumber != 0)
            {
                binaryConverter.Push(decimalNumber % 2);
                decimalNumber /= 2;
            }

            while (binaryConverter.Count > 0)
            {
                Console.Write(binaryConverter.Pop());
            }

            Console.WriteLine();
        }
    }
}
