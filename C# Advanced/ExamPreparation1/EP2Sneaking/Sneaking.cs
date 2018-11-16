using System;
using System.Collections.Generic;

namespace EP2Sneaking
{
    class Sneaking
    {
        static char[][] room;

        static int playerRow;
        static int playerCol;
        static int bossRow;
        static int bossCol;
        static List<int> enemiesRow = new List<int>();
        static bool won = false;
        static bool died = false;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            room = new char[size][];
            InitializeRoom(size);


            string directions = Console.ReadLine();

            PlayerMove(directions);


            // PrintRoom();
        }

        private static void EnemyTurn()
        {

            int enemyRow;
            int enemyCol;


            for (int row = 0; row < room.Length; row++)
            {
                if (!enemiesRow.Contains(row))
                {
                    continue;
                }
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'b' || room[row][col] == 'd')
                    {
                        enemyRow = row;
                        enemyCol = col;
                        EnemyMove(enemyRow, enemyCol);
                        row++;
                    }
                }

            }
        }

        private static void EnemyMove(int enemyRow, int enemyCol)
        {

            int targetCol = 0;

            isFacingPlayer(enemyRow, targetCol);

            if(died)
            {
                return;
            }

            if (room[enemyRow][enemyCol] == 'b')
            {
                //moves right;
                targetCol = enemyCol + 1;

                if (!isEdge(enemyRow, targetCol))
                {
                    room[enemyRow][enemyCol] = 'd';
                }
                else
                {
                    room[enemyRow][enemyCol] = '.';
                    room[enemyRow][targetCol] = 'b';
                    isFacingPlayer(enemyRow, targetCol);
                }
            }
            else
            {
                //moves left
                targetCol = enemyCol - 1;

                if (!isEdge(enemyRow, targetCol))
                {
                    room[enemyRow][enemyCol] = 'b';
                }
                else
                {
                    room[enemyRow][enemyCol] = '.';
                    room[enemyRow][targetCol] = 'd';
                    isFacingPlayer(enemyRow, targetCol);
                }
            }



        }

        private static void isFacingPlayer(int enemyRow, int targetCol)
        {
            if (enemyRow == playerRow)
            {
                if (room[enemyRow][targetCol] == 'b')
                {
                    if (targetCol < playerCol)
                    {
                        died = true;
                        room[playerRow][playerCol] = 'X';
                    }
                }
                else
                {
                    if (playerCol < targetCol)
                    {
                        died = true;
                        room[playerRow][playerCol] = 'X';

                    }
                }
            }
        }


        private static bool ReachedTarget()
        {
            return playerRow == bossRow;
        }

        private static bool isEdge(int row, int col)
        {
            return col >= 0 && col < room[row].Length;
        }

        private static void PlayerMove(string directions)
        {
            for (int i = 0; i < directions.Length; i++)
            {
                Console.WriteLine("Turn" + (int)(i + 1));
                EnemyTurn();
                //REMOVE
                Console.WriteLine("After enemy turn");
                PrintRoom();
                //REMOVE

                if (died)
                {
                    Console.WriteLine($"Sam died at {playerRow}, {playerCol}");
                    break;
                }
                else if (won)
                {
                    Console.WriteLine($"Nikoladze killed!");
                    room[bossRow][bossCol] = 'X';
                    break;
                }

                char move = directions[i];

                if (move == 'U')
                {
                    Move(-1, 0);
                }
                else if (move == 'L')
                {
                    Move(0, -1);
                }
                else if (move == 'R')
                {
                    Move(0, +1);
                }
                else if (move == 'D')
                {
                    Move(+1, 0);

                }
                else if (move == 'W')
                {
                    //waits
                }

                //REMOVE
                Console.WriteLine("After player move");
                PrintRoom();
                //REMOVE
            }
        }

        private static void Move(int row, int col)
        {
            room[playerRow][playerCol] = '.';
            playerRow += row;
            playerCol += col;
            room[playerRow][playerCol] = 'S';


            if (ReachedTarget())
            {
                won = true;
                return;
            }
            


        }

        static void InitializeRoom(int size)
        {
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                room[row] = line;

                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'S')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    if (room[row][col] == 'N')
                    {
                        bossRow = row;
                        bossCol = col;
                    }
                    if (room[row][col] == 'b' || room[row][col] == 'd')
                    {
                        enemiesRow.Add(row);
                    }
                }
            }


        }

        static void PrintRoom()
        {
            for (int i = 0; i < room.Length; i++)
            {
                Console.WriteLine(String.Join("", room[i]));
            }
        }
    }
}
