using System;
using System.Linq;

namespace P3PrimaryDiagonal
{
    class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                int[] fillLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = fillLine[j];
                }
            }

            int sum = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
