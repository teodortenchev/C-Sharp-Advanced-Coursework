using System;
using System.Linq;

namespace P7PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            Predicate<string> matchesConditionLength = s => s.Length <= nameLength;
            string[] names = Console.ReadLine().Split();
            string[] matches = names.Where(name => matchesConditionLength(name)).ToArray();

            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
            




        }
    }
}
