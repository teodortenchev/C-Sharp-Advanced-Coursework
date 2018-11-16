using System;
using System.Linq;

namespace P4FindEvenOrOdds
{
    class FindEvenOrOdds
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;
            int[] boundaries = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string condition = Console.ReadLine();

            if (condition == "even")
            {
                for (int i = boundaries[0]; i <= boundaries[1]; i++)
                {
                    if (isEven(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else if (condition == "odd")
            {
                for (int i = boundaries[0]; i <= boundaries[1]; i++)
                {
                    if (!isEven(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("I can only check for even or odd. You tried to make me do " + condition);
            }
            
            
        }
    }
}
