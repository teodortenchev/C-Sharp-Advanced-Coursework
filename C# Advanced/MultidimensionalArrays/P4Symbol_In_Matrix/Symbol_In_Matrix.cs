using System;

namespace P4Symbol_In_Matrix
{
    class Symbol_In_Matrix
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] charsFill = Console.ReadLine().ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = charsFill[j];
                }
            }

            char findChar = char.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    char currentChar = matrix[i, j];

                    if (currentChar == findChar)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{findChar} does not occur in the matrix");
        }
    }
}
