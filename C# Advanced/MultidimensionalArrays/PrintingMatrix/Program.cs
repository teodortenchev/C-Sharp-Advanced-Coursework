using System;

namespace PrintingMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 6, 4, 8, 3 },
                { 2, 3, 5, 7, 23 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 4, 4, 50 }
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    //print the elements with "," until the last
                    if (column < (matrix.GetLength(1) - 1))
                    {
                        Console.Write($"{matrix[row, column]}, ");
                    }
                    else
                    {
                        Console.Write($"{matrix[row, column]}");
                    }

                }
                Console.WriteLine();
            }

            //foreach (var element in matrix)
            //{
            //    Console.WriteLine(element);
            //}

        }
    }
}
