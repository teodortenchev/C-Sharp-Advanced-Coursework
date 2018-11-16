using System;
using System.Linq;

namespace P5AppliedArithmetics
{
    class AppliedArithmetics
    {
        public delegate int[] MathFunctions(int[] nums);

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

           


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                switch (command)
                {
                    case "add":
                        numbers = AddOneFunc(numbers);
                        break;
                    case "multiply":
                        numbers = Multiply(numbers);
                        break;
                    case "subtract":
                        numbers = Subtract(numbers);
                        break;
                    case "print":
                        Print(numbers);
                        break;

                    default:
                        break;
                }
                
                
            }
        }

       
        public static Func<int[], int[]> AddOneFunc = nums => nums.Select(x => x + 1).ToArray();
        public static Func<int[], int[]> Multiply = nums => nums.Select(x => x * 2).ToArray();
        public static Func<int[], int[]> Subtract = nums => nums.Select(x => x - 1).ToArray();
        public static Action<int[]> Print = nums => Console.WriteLine(String.Join(" ", nums));



    }
}
