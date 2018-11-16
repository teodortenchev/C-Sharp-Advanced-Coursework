using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSameValuesInArray
{
    class CountSameValues
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Dictionary<double, int> countNumbers = new Dictionary<double, int>();

            foreach (var item in numbers)
            {
                if (countNumbers.ContainsKey(item))
                {
                    countNumbers[item]++;
                }
                else
                {
                    countNumbers.Add(item, 1);
                }
            }

            foreach (var item in countNumbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
