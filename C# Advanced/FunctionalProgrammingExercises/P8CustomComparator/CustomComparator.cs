using System;
using System.Linq;

namespace P8CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Action<int[]> print = p => Console.WriteLine(String.Join(" ", p));
            Func<int, int, int> sortFunc = (a, b) =>
                                            (a % 2 == 0 && b % 2 != 0) ? -1 :
                                            (a % 2 != 0 && b % 2 == 0) ? 1 :
                                            a.CompareTo(b);

            Array.Sort(numbers, new Comparison<int>(sortFunc));

            print(numbers);

        }
    }
}
