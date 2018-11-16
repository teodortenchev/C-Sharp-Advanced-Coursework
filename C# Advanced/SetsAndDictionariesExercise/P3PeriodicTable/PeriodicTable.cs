using System;
using System.Collections.Generic;

namespace P3PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int compoundsCount = int.Parse(Console.ReadLine());
            SortedSet<string> chemicals = new SortedSet<string>();

            for (int i = 0; i < compoundsCount; i++)
            {
                string[] elements = Console.ReadLine().Split();
                foreach (var element in elements)
                {
                    chemicals.Add(element);
                }
            }

            Console.WriteLine(String.Join(" ", chemicals));
        }
    }
}
