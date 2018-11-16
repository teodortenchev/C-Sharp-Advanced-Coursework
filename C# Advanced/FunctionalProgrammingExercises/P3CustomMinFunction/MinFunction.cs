using System;
using System.Linq;

namespace P3CustomMinFunction
{
    class MinFunction
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = func(numbers);
            Console.WriteLine(result);
        }

        static Func<int[], int> func = n => n.Min();  
    }
}
