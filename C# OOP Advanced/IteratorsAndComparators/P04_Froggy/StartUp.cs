using System;
using System.Linq;

namespace P04_Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine().Split(new char[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var lake = new Lake(stones);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
