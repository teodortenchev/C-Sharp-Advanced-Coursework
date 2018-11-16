using System;
using System.Linq;

namespace P2SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(Parse).ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }

        static Func<string, int> Parse = x =>
        {
            int result = 0;

            if (int.TryParse(x, out result))
            {
                return result;
            }

            return 0;
        };
    }
}
