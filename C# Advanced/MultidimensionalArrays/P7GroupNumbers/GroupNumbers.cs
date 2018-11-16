using System;
using System.Collections.Generic;
using System.Linq;

namespace P7GroupNumbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            int[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            jagged[0] = input.Where(x => Math.Abs(x) % 3 == 0).ToArray();
            jagged[1] = input.Where(x => Math.Abs(x) % 3 == 1).ToArray();
            jagged[2] = input.Where(x => Math.Abs(x) % 3 == 2).ToArray();


            foreach (int[] array in jagged)
            {
                Console.WriteLine(String.Join(" ", array));
            }







        }
    }
}
