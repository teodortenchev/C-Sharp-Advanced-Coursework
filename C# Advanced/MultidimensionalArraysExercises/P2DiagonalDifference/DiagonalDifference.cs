using System;
using System.Linq;

namespace P2DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            int leftDiagonal = 0;
            int rightDiagonal = 0;
            int result = 0;


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] fillMatrix = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = fillMatrix[j];
                }
            }

            for (int i = 0; i < matrixSize; i++)
            {
                leftDiagonal += matrix[i, i];
            }


            for (int i = 0; i < matrixSize; i++)
            {
                rightDiagonal += matrix[i, matrixSize - i - 1];
            }

            result = Math.Abs(leftDiagonal - rightDiagonal);
            Console.WriteLine(result);
        }
    }
}
