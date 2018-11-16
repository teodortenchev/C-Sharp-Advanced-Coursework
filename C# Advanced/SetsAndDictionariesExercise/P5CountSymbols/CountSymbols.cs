using System;
using System.Collections.Generic;

namespace P5CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> characterCounts = new SortedDictionary<char, int>();

            foreach (var character in text)
            {
                if(!characterCounts.ContainsKey(character))
                {
                    characterCounts.Add(character, 1);
                }
                else
                {
                    characterCounts[character]++;
                }
            }

            foreach (var symbol in characterCounts)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
