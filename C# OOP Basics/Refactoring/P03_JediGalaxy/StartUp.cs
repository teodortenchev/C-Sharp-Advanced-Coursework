using System;
using System.Linq;

namespace P03_JediGalaxy
{
    public class StartUp
    {
        public static Board board;

        static void Main()
        {
            int[] dimension = Console.ReadLine()
                                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse).ToArray();

            board = new Board(dimension[0], dimension[1]);
            Player player = new Player();

            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                int[] evilCoordinates = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse).ToArray();

                Player evil = new Player(evilCoordinates[0], evilCoordinates[1]);

                Player.MoveEnemy(evil);

                int[] playerCoordinates = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                player = new Player(playerCoordinates[0], playerCoordinates[1]);

                Player.MovePlayer(player);

                command = Console.ReadLine();
            }

            long result = player.StarsCollected;
            Console.WriteLine(result);

        }
    }
}
