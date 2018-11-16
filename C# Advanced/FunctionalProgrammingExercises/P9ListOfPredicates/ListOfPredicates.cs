using System;
using System.Collections.Generic;
using System.Linq;

namespace P9ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            int upperBoundary = int.Parse(Console.ReadLine());
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToList();
            List<int> result = new List<int>(); 
            Func<int, int, bool> func = (num, set) => num % set == 0;

            for (int i = 1; i <= upperBoundary; i++)
            {
                foreach (var item in sequence)
                {
                    if (func(i, item))
                    {
                        result.Add(i);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", result.Distinct()));
        }
    }
}
