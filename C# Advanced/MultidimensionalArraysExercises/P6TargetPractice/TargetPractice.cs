using System;
using System.Linq;

namespace P6TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            int[] dimensions = { 5, 6 };
            //Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string snake = "SoftUni";
            //int[] shotParameters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] stairs = new char[dimensions[0], dimensions[1]];

            ClimbStairs(snake, stairs);

            PrintStairs(stairs);
        }

        private static void ClimbStairs(string snake, char[,] stairs)
        {
            char[] snakeParts = snake.ToCharArray();

            for (int row = stairs.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = stairs.GetLength(1) - 1; col >= 0; col--)
                {
                        
                        stairs[row, col] = snakeParts[stairs.GetLength(1)- 1 - col];
                    
                }
            }
        }

        private static void PrintStairs(char[,] stairs)
        {
            for (int i = 0; i < stairs.GetLength(0); i++)
            {
                for (int j = 0; j < stairs.GetLength(1); j++)
                {
                    Console.Write($"{stairs[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
