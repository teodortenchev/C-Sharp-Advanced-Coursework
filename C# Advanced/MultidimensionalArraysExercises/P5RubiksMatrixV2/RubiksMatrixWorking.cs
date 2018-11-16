using System;
using System.Linq;

namespace P5RubiksMatrixV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] rubiksMatrix = FillMatrix(dimensions[0], dimensions[1]);
            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int position = int.Parse(tokens[0]);
                int actionsCount = int.Parse(tokens[2]);
                string command = tokens[1].ToLower();

                if (command == "up")
                {
                    ShiftUp(rubiksMatrix, actionsCount % rubiksMatrix.GetLength(0), position);
                }
                else if (command == "down")
                {
                    ShiftDown(rubiksMatrix, actionsCount % rubiksMatrix.GetLength(0), position);
                }
                else if (command == "left")
                {
                    ShiftLeft(rubiksMatrix, actionsCount % rubiksMatrix.GetLength(1), position);
                }
                else if (command == "right")
                {
                    ShiftRight(rubiksMatrix, actionsCount % rubiksMatrix.GetLength(1), position);
                }
                else
                {
                    Console.WriteLine($"Unrecognized command '{command}'.");
                }
            }

            Arrange(rubiksMatrix);
            //PrintMatrix(rubiksMatrix);
        }

        static int[,] FillMatrix(int dimension1, int dimension2)
        {
            int[,] matrix = new int[dimension1, dimension2];
            int increment = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = increment;
                    increment++;
                }
            }
            return matrix;
        }

        static int[,] ShiftUp(int[,] matrix, int times, int column)
        {
            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < matrix.GetLength(0) - 1; j++)
                {
                    int temp = matrix[j, column];
                    matrix[j, column] = matrix[j + 1, column];
                    matrix[j + 1, column] = temp;
                }
            }
            return matrix;
        }

        static int[,] ShiftDown(int[,] matrix, int times, int column)
        {

            int[] shifted = new int[matrix.GetLength(0)];

            for (int i = 0; i < times; i++)
            {
                shifted[0] = matrix[matrix.GetLength(0) - 1, column];

                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    shifted[j] = matrix[j - 1, column];
                }

                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    matrix[k, column] = shifted[k];
                }
            }

            return matrix;
        }

        static int[,] ShiftLeft(int[,] matrix, int times, int row)
        {
            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int temp = matrix[row, j];
                    matrix[row, j] = matrix[row, j + 1];
                    matrix[row, j + 1] = temp;
                }
            }
                return matrix;
        }

        static int[,] ShiftRight(int[,] matrix, int times, int row)
        {
            for (int i = 0; i < times; i++)
            {
                int[] shifted = new int[matrix.GetLength(1)];
                shifted[0] = matrix[row, matrix.GetLength(1) - 1];

                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    shifted[j] = matrix[row, j - 1];
                }

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[row, k] = shifted[k];
                }
            }

            return matrix;
        }

        static int[,] Shuffle (int[,] rubiksMatrix, int commandsCount)
        {
            

            return rubiksMatrix;
        }

        static void Arrange (int[,] matrix)
        {
            
            int counter = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == counter)
                    {
                        Console.WriteLine("No swap required");
                        

                    } else
                    {
                        

                        RearrangeMatrix(matrix, i, j, counter);
                    }

                    counter++;
                }
            }
        }

        static void RearrangeMatrix(int[,] matrix, int row, int col, int counter)
        {
            for (int targetRow = 0; targetRow < matrix.GetLength(0); targetRow++)
            {
                for (int targetCol = 0; targetCol < matrix.GetLength(1); targetCol++)
                {
                    if (matrix[targetRow, targetCol] == counter)
                    {
                        matrix[targetRow, targetCol] = matrix[row, col];
                        matrix[row, col] = counter;

                        Console.WriteLine($"Swap ({row}, {col}) with ({targetRow}, {targetCol})");

                        return;
                    }
                }
            }
        }
        //static void PrintMatrix(int[,] matrix)
        //{
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            if (j != matrix.GetLength(1) - 1)
        //            {
        //                Console.Write($"{matrix[i, j]} ");

        //            }
        //            else
        //            {
        //                Console.Write(matrix[i, j]);
        //            }

        //        }
        //        Console.WriteLine();
        //    }
        //}


        


    }
}
