using System;
using System.Linq;

namespace P3CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(checker)
                .ToList().ForEach(Console.WriteLine);

        }
        static Func<string, bool> checker = n => Char.IsUpper(n[0]);
    }
}
