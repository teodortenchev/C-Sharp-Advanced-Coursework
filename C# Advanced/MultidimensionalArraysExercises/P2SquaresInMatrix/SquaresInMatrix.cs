using System;
using System.Linq;

namespace P2SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(' ', options: StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            char[,] matrix = new char[matrixSizes[0], matrixSizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] fillMatrixRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = fillMatrixRow[col];
                }
            }

            int count = 0;


            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            if (count != 0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(count);
            }


        }
    }
}
