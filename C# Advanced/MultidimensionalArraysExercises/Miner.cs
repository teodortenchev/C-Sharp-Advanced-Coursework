using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            char[,] field = new char[fieldSize, fieldSize];

            string[] movementParams = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] recognizedCommands = new string[] { "left", "right", "up", "down" };

            for (int i = 0; i < fieldSize; i++)
            {
                char[] items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j = 0; j < fieldSize; j++)
                {
                    field[i, j] = items[j];
                }
            }

            var minerLocation = GetStartingPosition(field);

            int totalCoals = ReturnCoalCount(field);

            bool gameIsOver = false;

            foreach (var command in movementParams)
            {
                if (recognizedCommands.Contains(command))
                {
                    int newRow = -1;
                    int newCol = -1;

                    if (command == "left")
                    {
                        newRow = minerLocation[0];
                        newCol = minerLocation[1] - 1;                  
                    }

                    else if (command == "right")
                    {
                        newRow = minerLocation[0];
                        newCol = minerLocation[1] + 1;
                    }
                    else if (command == "up")
                    {
                        newRow = minerLocation[0] - 1;
                        newCol = minerLocation[1];                      
                    }
                    else
                    {
                        newRow = minerLocation[0] + 1;
                        newCol = minerLocation[1];
                    }

                    if (!IsOutOfBounds(fieldSize, new int[] { newRow, newCol }))
                    {
                        if (ReachedEndOfRoute(field, new int[] { newRow, newCol }))
                        {
                            Console.WriteLine($"Game over! ({newRow}, {newCol})");
                            gameIsOver = true;
                            break;
                        }

                        minerLocation = new int[] { newRow, newCol };


                        if (FoundCoal(field, minerLocation))
                        {
                            field[newRow, newCol] = '*';
                            totalCoals--;
                        }                        
                    }

                    if (totalCoals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({newRow}, {newCol})");
                        break;
                    }
                }
            }

            if(totalCoals > 0 && !gameIsOver)
            {
                Console.WriteLine($"{totalCoals} coals left. ({minerLocation[0]}, {minerLocation[1]})");
            }

        }


        private static int ReturnCoalCount(char[,] field)
        {
            int count = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'c')
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private static bool FoundCoal(char[,] field, int[] currentPosition)
        {
            return field[currentPosition[0], currentPosition[1]] == 'c';
        }

        private static bool ReachedEndOfRoute(char[,] field, int[] currentPosition)
        {
            return field[currentPosition[0], currentPosition[1]] == 'e';
        }

        private static bool IsOutOfBounds(int fieldSize, int[] newPosition)
        {
            return newPosition[0] < 0 || newPosition[1] < 0 || newPosition[0] > fieldSize - 1 || newPosition[1] > fieldSize - 1;
        }

        private static int[] GetStartingPosition(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 's')
                    {
                        return new int[] { row, col };
                    }
                }
            }

            return new int[] { 0, 0 };
        }
    }
}
