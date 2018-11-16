using System;
using System.Linq;

namespace P1SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).
                Where(n => n % 2 == 0).OrderBy(n => n).ToArray();

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
