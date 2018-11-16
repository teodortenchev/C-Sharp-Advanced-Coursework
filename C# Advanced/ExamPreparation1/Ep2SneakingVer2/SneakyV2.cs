using System;
using System.Collections.Generic;
namespace Ep2SneakingVer2
{
    class SneakyV2
    {
        static char[][] room;
        static int playerRow;
        static int playerCol;
        static int bossRow;
        static int bossCol;
        static bool dead = false;
        static bool wins = false;
        static int rows;
        static List<int> enemyRows;

        static void Main(string[] args)
        {
            rows = int.Parse(Console.ReadLine());

            InitializeRoom(rows);
            Queue<char> movesQueue = new Queue<char>(Console.ReadLine().ToCharArray());


            while (true)
            {
                if (dead)
                {
                    Console.WriteLine($"Sam died at {playerRow}, {playerCol}");
                    PrintRoom();
                }

                EnemyTurn();


                if (dead)
                {
                    break;
                }

                PlayerTurn(movesQueue);

                if (dead)
                {
                    break;
                }
                if (wins)
                {
                    break;
                }
            }

            if (dead)
            {
                Console.WriteLine($"Sam died at {playerRow}, {playerCol}");
                PrintRoom();
            }
            else
            {
                Console.WriteLine($"Nikoladze killed!");
                PrintRoom();
            }
        }

        private static void PlayerTurn(Queue<char> playerMoves)
        {


            if (playerMoves.Count > 0)
            {
                char move = playerMoves.Dequeue();

                switch (move)
                {
                    case 'U':
                        Move(-1, 0);
                        break;

                    case 'D':
                        Move(+1, 0);
                        break;

                    case 'R':
                        Move(0, +1);
                        break;

                    case 'L':
                        Move(0, -1);
                        break;
                    case 'W':
                        //Waiting
                        break;

                    default:
                        Console.WriteLine("Unrecognized move command");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No more player moves left");
            }
        }

        private static void Move(int row, int col)
        {
            room[playerRow][playerCol] = '.';
            playerRow += row;
            playerCol += col;

            if (enemyRows.Contains(playerRow))
            {
                if (playerCol == FindCol(playerRow))
                {
                    enemyRows.Remove(playerRow);
                }
            }


            room[playerRow][playerCol] = 'S';

            if (enemyRows.Contains(playerRow))
            {
                int enemyCol = FindCol(playerRow);
                if (KillsPlayer(playerRow, enemyCol))
                {
                    room[playerRow][playerCol] = 'X';
                    dead = true;
                }

            }

            if (playerRow == bossRow)
            {
                room[bossRow][bossCol] = 'X';
                wins = true;

            }



        }






        //100% Working Functions
        private static void EnemyTurn()
        {
            for (int i = 0; i < room.Length; i++)
            {
                if (enemyRows.Contains(i))
                {
                    int enemyRow = i;
                    int enemyCol = FindCol(i);

                    if (room[enemyRow][enemyCol] == 'b')
                    {

                        if (isRightEdge(enemyRow, enemyCol))
                        {
                            room[enemyRow][enemyCol] = 'd';

                            if (KillsPlayer(enemyRow, enemyCol) && enemyRow == playerRow)
                            {
                                room[playerRow][playerCol] = 'X';
                                dead = true;
                            }
                        }
                        else
                        {
                            room[enemyRow][enemyCol] = '.';
                            room[enemyRow][enemyCol + 1] = 'b';

                            if (KillsPlayer(enemyRow, enemyCol + 1) && enemyRow == playerRow)
                            {
                                room[playerRow][playerCol] = 'X';
                                dead = true;
                            }

                        }
                    }
                    else
                    {

                        if (isLeftEdge(enemyRow, enemyCol))
                        {
                            room[enemyRow][enemyCol] = 'b';

                            if (KillsPlayer(enemyRow, enemyCol) && enemyRow == playerRow)
                            {
                                room[playerRow][playerCol] = 'X';
                                dead = true;
                            }
                        }
                        else
                        {
                            room[enemyRow][enemyCol] = '.';
                            room[enemyRow][enemyCol - 1] = 'd';

                            if (KillsPlayer(enemyRow, enemyCol - 1) && enemyRow == playerRow)
                            {
                                room[playerRow][playerCol] = 'X';
                                dead = true;
                            }
                        }
                    }

                }

                if (dead)
                {
                    break;
                }
            }
        }

        private static bool KillsPlayer(int enemyRow, int enemyCol)
        {
            if (room[enemyRow][enemyCol] == 'b')
            {

                return enemyCol < playerCol;
            }
            else
            {
                return playerCol < enemyCol;
            }
        }

        private static int FindCol(int row)
        {
            for (int col = 0; col < room[row].Length; col++)
            {
                if (room[row][col] == 'b' || room[row][col] == 'd')
                {
                    return col;
                }
            }

            return -1;
        }
        private static void PrintRoom()
        {
            foreach (char[] row in room)
            {
                Console.WriteLine(String.Join("", row));
            }
        }
        private static void InitializeRoom(int rows)
        {
            //Fills in the play field, detects the  player and boss positions
            room = new char[rows][];
            enemyRows = new List<int>();

            for (int row = 0; row < room.Length; row++)
            {

                room[row] = Console.ReadLine().ToCharArray();

                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'N')
                    {
                        bossRow = row;
                        bossCol = col;
                    }
                    else if (room[row][col] == 'S')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    else if (room[row][col] != '.')
                    {
                        enemyRows.Add(row);
                        
                    }
                }
            }
            if (enemyRows.Contains('S'))
            {
                int enemyRow = playerRow;
                int enemyCol = FindCol(enemyRow);

                if (room[enemyRow][enemyCol] == 'b' && enemyCol < playerCol)
                {
                    dead = true;
                }
                else if (room[enemyRow][enemyCol] == 'd' && enemyCol > playerCol)
                {
                    dead = true;
                }
            } 
        }
        private static bool isRightEdge(int row, int col)
        {
            return col == room[row].Length - 1;
        }
        private static bool isLeftEdge(int row, int col)
        {
            return col == 0;
        }
    }
}
