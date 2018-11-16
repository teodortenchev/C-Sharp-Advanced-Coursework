using System;
using System.Collections.Generic;
using System.Linq;

namespace P2RadioActiveBunniesAlone
{
    class Program
    {
        static char[][] layer;
        static int playerRow;
        static int playerCol;
        static bool won;
        static bool died;

        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            layer = new char[rows][];

            InitializeLayer(cols);


            string directions = Console.ReadLine();

            PlayerMove(directions);

        }

        private static void PlayerMove(string directions)
        {
            for (int i = 0; i < directions.Length; i++)
            {
                char move = directions[i];
                if (move == 'R')
                {
                    Move(0, +1);
                }
                else if (move == 'L')
                {
                    Move(0, -1);
                }
                else if (move == 'U')
                {
                    Move(-1, 0);
                }
                else if (move == 'D')
                {
                    Move(+1, 0);
                }

                SpawnBunnies();
              

                if (won)
                {
                    PrintLayer();
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    break;
                }
                else if (died)
                {
                    PrintLayer();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");

                    break;
                }




            }
        }

        private static void SpawnBunnies()
        {
            Queue<int[]> bunnies = new Queue<int[]>();

            for (int row = 0; row < layer.Length; row++)
            {
                for (int col = 0; col < layer[row].Length; col++)
                {
                    if (layer[row][col] == 'B')
                    {
                        bunnies.Enqueue(new int[] { row, col });
                    }
                }
            }

            while (bunnies.Count > 0)
            {
                int[] indexes = bunnies.Dequeue();
                int row = indexes[0];
                int col = indexes[1];

                //spawn up
                if (IsInside(row - 1, col))
                {
                    if (IsPlayer(row - 1, col))
                    {
                        died = true;
                    }
                    if (layer[row-1][col] != 'B')
                    {
                        layer[row - 1][col] = 'B';
                    }
                }
                //spawn down
                if (IsInside(row + 1, col))
                {
                    if (IsPlayer(row + 1, col))
                    {
                        died = true;
                    }
                    if (layer[row + 1][col] != 'B')
                    {
                        layer[row + 1][col] = 'B';
                    }
                    
                }
                //spawn left
                if (IsInside(row, col - 1))
                {
                    if (IsPlayer(row, col - 1))
                    {
                        died = true;
                        
                    }
                    if (layer[row][col - 1] != 'B')
                    {
                        layer[row][col - 1] = 'B';
                    }
                   
                }
                //spawn right
                if (IsInside(row, col + 1))
                {
                    if (IsPlayer(row, col + 1))
                    {
                        died = true;
                        
                    }
                    if (layer[row][col + 1] != 'B')
                    {
                        layer[row][col + 1] = 'B';
                    }
                   
                }
            }
        }

        private static bool IsPlayer(int targetRow, int targetCol)
        {
            return playerRow == targetRow && playerCol == targetCol;
        }

        private static void Move(int row, int col)
        {
            int targetRow = playerRow + row;
            int targetCol = playerCol + col;

            if (!IsInside(targetRow, targetCol))
            {
                won = true;
                layer[playerRow][playerCol] = '.';
                
            }
            else if (IsBunny(targetRow, targetCol))
            {
                died = true;
                layer[playerRow][playerCol] = '.';
                playerRow = targetRow;
                playerCol = targetCol;
            }
            else
            {
                layer[playerRow][playerCol] = '.';
                layer[targetRow][targetCol] = 'P';
                playerRow = targetRow;
                playerCol = targetCol;

            }



        }

        private static bool IsBunny(int row, int col)
        {
            return layer[row][col] == 'B';
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < layer.Length && col >= 0 && col < layer[row].Length;
        }

        private static void PrintLayer()
        {
            for (int i = 0; i < layer.Length; i++)
            {
                Console.WriteLine(String.Join("", layer[i]));
            }
        }

        private static void InitializeLayer(int cols)
        {
            for (int row = 0; row < layer.Length; row++)
            {
                string input = Console.ReadLine();

                layer[row] = new char[cols];

                for (int col = 0; col < layer[row].Length; col++)
                {
                    layer[row][col] = input[col];
                    if (input[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
