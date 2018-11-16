using System;
using System.Collections.Generic;
using System.Linq;

namespace P6ReverseExclude
{
    class ReverseExclude
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).Reverse().ToList();
            
            int divisionNumber = int.Parse(Console.ReadLine());
            numbers.RemoveAll(isDivisible);
            bool isDivisible(int n) => n % divisionNumber == 0;

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
