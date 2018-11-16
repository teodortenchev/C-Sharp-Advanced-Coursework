using System;

namespace FunctionalProgramming
{
    class Delegates
    {
        //public delegate string BinaryOperator(int x, int y);
        static void Main(string[] args)
        {
            Func<int, int, string> opMultiply = IsGreater;
            Console.WriteLine(Calculator(4, 5, Multiply));
            
            Console.WriteLine(opMultiply(4,5));
            
             
        }

        public static string Calculator(int x, int y, Func<int, int, string> op)
        {
            return op(x, y);
        }

        public static string Multiply(int x, int y)
        {
            return (x * y).ToString();
        }

        public static string Add(int x, int y)
        {
            return (x + y).ToString();
        }

        public static string IsGreater(int z, int m)
        {
            return (z > m).ToString();
        }
    }
}
