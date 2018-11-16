using System;
using System.Linq;

namespace P5RubiksMatrix
{
    class RubiksMatrix
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[][] rubikMatrix = new int[rows][];
            FillMatrix(rubikMatrix, cols);

            int commandsCout = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCout; i++)
            {
                string[] input = Console.ReadLine().Split();
                int rowColIndex = int.Parse(input[0]);
                string direction = input[1];
                int moves = int.Parse(input[2]);

                if (direction == "up")
                {
                    ShiftUp(rubikMatrix, moves % rubikMatrix.Length, rowColIndex);
                }
                else if (direction == "down")
                {
                    ShiftDown(rubikMatrix, moves % rubikMatrix.Length, rowColIndex);
                }
                else if (direction == "left")
                {
                    ShiftLeft(rubikMatrix, moves % rubikMatrix.Length, rowColIndex);
                }
                else if (direction == "right")
                {
                    ShiftRight(rubikMatrix, moves % rubikMatrix.Length, rowColIndex);
                }
                else
                {
                    Console.WriteLine($"Unrecognized direction '{direction}'.");
                }
            }

            // Printmatrix(rubikMatrix);

            Arrange(rubikMatrix);
            
        }

        private static void Printmatrix(int[][] rubikMatrix)
        {
            for (int i = 0; i < rubikMatrix.Length; i++)
            {
                Console.WriteLine(String.Join(" ", rubikMatrix[i]));
            }
        }

        private static void FillMatrix(int[][] rubikMatrix, int cols)
        {
            int counter = 1;
            for (int row = 0; row < rubikMatrix.Length; row++)
            {
                rubikMatrix[row] = new int[cols];
                for (int col = 0; col < rubikMatrix[row].Length; col++)
                {
                    rubikMatrix[row][col] = counter++;
                }
            }
        }

        private static void ShiftUp(int[][] matrix, int times, int column)
        {
            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < matrix.Length - 1; j++)
                {
                    int temp = matrix[j][column];
                    matrix[j][column] = matrix[j + 1][column];
                    matrix[j + 1][column] = temp;
                }
            }

        }

        private static void ShiftDown(int[][] matrix, int times, int column)
        {
            for (int i = 0; i < times; i++)
            {
                int lastElement = matrix[matrix.Length - 1][column];

                for (int row = matrix.Length - 1; row > 0; row--)
                {
                    matrix[row][column] = matrix[row - 1][column];
                }

                matrix[0][column] = lastElement;
            }
        }

        private static void ShiftLeft(int[][] matrix, int times, int row)
        {
            for (int i = 0; i < times; i++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    int temp = matrix[row][col];
                    matrix[row][col] = matrix[row][col + 1];
                    matrix[row][col + 1] = temp;
                }
            }
        }

        private static void ShiftRight(int[][] matrix, int times, int rows)
        {
            for (int i = 0; i < times; i++)
            {
                int lastElement = matrix[rows][matrix[rows].Length - 1];

                for (int col = matrix[rows].Length - 1; col > 0; col--)
                {
                    matrix[rows][col] = matrix[rows][col - 1];
                }

                matrix[rows][0] = lastElement;
            }
        }

        private static void Arrange(int[][] matrix)
        {
            int counter = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == counter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        RearrangeMatrix(matrix, row, col, counter);
                    }
                    counter++;
                }
            }
        }

        private static void RearrangeMatrix(int[][] matrix, int row, int col, int counter)
        {
            for (int targetRow = 0; targetRow < matrix.Length; targetRow++)
            {
                for (int targetCol = 0; targetCol < matrix[targetRow].Length; targetCol++)
                {
                    if (matrix[targetRow][targetCol] == counter)
                    {
                        matrix[targetRow][targetCol] = matrix[row][col];
                        matrix[row][col] = counter;

                        Console.WriteLine($"Swap ({row}, {col}) with ({targetRow}, {targetCol})");
                        return;
                    }
                }
            }
        }
    }
}
