using System;
using System.Collections.Generic;
using System.Linq;

namespace P6TargetPracticeGuided
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[][] matrix = new char[rows][];
            string snake = Console.ReadLine();
            GetMatrix(matrix, cols, snake);

            int[] shotParameters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            ShootSnake(matrix, shotParameters);
           
           
            DropDead(matrix, rows);

            PrintMatrix(matrix);
        }

        private static void DropDead(char[][] matrix, int rows)
        {

            for (int col = 0; col < matrix[0].Length; col++)
            {
                Queue<char> elements = new Queue<char>(matrix.Length);

                int counter = 0;

                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row][col] != ' ')
                    {
                        elements.Enqueue(matrix[row][col]);
                    }
                    else
                    {
                        counter++;
                    }
                }

                for (int row = 0; row < counter; row++)
                {
                    matrix[row][col] = ' ';
                }

                for (int row = counter; row < matrix.Length; row++)
                {
                    matrix[row][col] = elements.Dequeue();
                }
            }
          
        }

        private static void ShootSnake(char[][] matrix, int[] shotParameters)
        {
            int targetRow = shotParameters[0];
            int targetCol = shotParameters[1];
            int radius = shotParameters[2];

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    bool inRange = Math.Pow((targetRow - row), 2) + Math.Pow((targetCol - col), 2) <= Math.Pow(radius, 2);

                    if (inRange)
                    {
                        matrix[row][col] = ' ';
                    }
                }
            }

        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(String.Join("", matrix[i]));
            }
        }

        private static void GetMatrix(char[][] matrix, int cols, string snake)
        {
            int counter = 0;
            bool isLeft = true;
            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                matrix[row] = new char[cols];

                if (isLeft)
                {
                    for (int col = matrix[row].Length - 1; col >= 0; col--)
                    {
                        matrix[row][col] = snake[counter++ % snake.Length];
                    }
                    isLeft = false;
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] = snake[counter++ % snake.Length];
                    }

                    isLeft = true;
                }

            }
        }
    }
}
