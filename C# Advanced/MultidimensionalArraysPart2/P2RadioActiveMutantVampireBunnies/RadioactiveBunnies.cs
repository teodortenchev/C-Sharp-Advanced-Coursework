using System;
using System.Collections.Generic;
using System.Linq;

namespace P2RadioActiveMutantVampireBunnies
{

    class RadioactiveBunnies
    {

        static int playerRow;
        static int playerCol;
        static char[][] layer;
        static bool isOutside;
        static bool isDead;

        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            layer = new char[rows][];

            GetLayer(cols);



            string directions = Console.ReadLine();

            MovePlayer(directions);

            

           

        }


        private static void MovePlayer(string directions)
        {
            for (int i = 0; i < directions.Length; i++)
            {
                char currentStep = directions[i];

                if (currentStep == 'U')
                {
                    Move(-1, 0);
                }
                else if (currentStep == 'L')
                {
                    Move(0, -1);
                }
                else if (currentStep == 'R')
                {
                    Move(0, +1);
                }
                else if (currentStep == 'D')
                {
                    Move(1, 0);
                }

                SpawnBunnies();

                if (isDead)
                {
                    PrintLayerState();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    break;
                }
                else if (isOutside)
                {
                    layer[playerRow][playerCol] = '.';
                    PrintLayerState();
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    break;
                }
                
            }
        }

        private static void SpawnBunnies()
        {
            Queue<int[]> indexes = new Queue<int[]>();

            for (int row = 0; row < layer.Length; row++)
            {
                for (int col = 0; col < layer[row].Length; col++)
                {
                    if (layer[row][col] == 'B')
                    {
                        indexes.Enqueue(new int[] { row, col });
                    }
                }
            }

            while (indexes.Count > 0)
            {
                int[] currentIndex = indexes.Dequeue();

                int targetRow = currentIndex[0];
                int targetCol = currentIndex[1];

                //spawn up
                if (IsInside(targetRow - 1, targetCol))
                {
                    if(layer[targetRow - 1][targetCol] == 'P')
                    {
                        isDead = true;
                    }
                    layer[targetRow - 1][targetCol] = 'B';
                }

                //spawn right
                if (IsInside(targetRow, targetCol + 1))
                {
                    if (layer[targetRow][targetCol + 1] == 'P')
                    {
                        isDead = true;
                    }
                    layer[targetRow][targetCol + 1] = 'B';
                }

                //spawn down
                if (IsInside(targetRow + 1, targetCol))
                {
                    if (layer[targetRow + 1][targetCol] == 'P')
                    {
                        isDead = true;
                    }
                    layer[targetRow + 1][targetCol] = 'B';
                }

                //spawn left
                if (IsInside(targetRow, targetCol - 1))
                {
                    if (layer[targetRow][targetCol - 1] == 'P')
                    {
                        isDead = true;
                    }
                    layer[targetRow][targetCol - 1] = 'B';
                }
            }
        }

        private static void Move(int row, int col)
        {
            int targetRow = playerRow + row;
            int targetCol = playerCol + col;

            if (!IsInside(targetRow, targetCol))
            {
                isOutside = true;
            }

            else if (IsBunny(targetRow, targetCol))
            {
                layer[playerRow][playerCol] = '.';
                playerRow += row;
                playerCol += col;
                isDead = true;

            }

            else
            {
                layer[playerRow][playerCol] = '.';
                playerRow += row;
                playerCol += col;
                layer[playerRow][playerCol] = 'P';
            }



        }

        private static bool IsBunny(int targetRow, int targetCol)
        {
            return layer[targetRow][targetCol] == 'B';
        }

        private static bool IsInside(int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < layer.Length && targetCol >= 0 && targetCol < layer[targetRow].Length;
        }

        private static void GetLayer(int cols)
        {
            for (int row = 0; row < layer.Length; row++)
            {
                string input = Console.ReadLine();

                layer[row] = new char[cols];

                for (int col = 0; col < layer[row].Length; col++)
                {
                    layer[row][col] = input[col];

                    if (layer[row][col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }

        private static void PrintLayerState()
        {
            for (int i = 0; i < layer.Length; i++)
            {
                Console.WriteLine(String.Join("", layer[i]));
            }
        }
    }
}
