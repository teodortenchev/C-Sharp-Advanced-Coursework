using System;
using System.Linq;

namespace P4MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(' ', options: StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];

            int maxSum = int.MinValue;
            int currentRow = -1;
            int currentCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] fillMatrixRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = fillMatrixRow[col];
                }
            }




            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = (matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2])
                        + (matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2])
                        + (matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2]);
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        currentRow = row;
                        currentCol = col;
                    }
                }

            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j < 2)
                    {
                        Console.Write($"{matrix[currentRow + i, currentCol + j]} ");
                    }
                    else
                    {
                        Console.Write($"{matrix[currentRow + i, currentCol + j]}");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
