using System;
using System.Collections.Generic;

namespace P4EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> numbersCountainer = new Dictionary<string, int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                if (!numbersCountainer.ContainsKey(input))
                {
                    numbersCountainer[input] = 1;
                }
                else
                {
                numbersCountainer[input]++;
                }
            }

            foreach (var item in numbersCountainer)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}
