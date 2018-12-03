namespace P03_JediGalaxy
{
    public class Player
    {
        private int row;
        private int col;
        private long starsCollected;

        public Player()
        {
            StarsCollected = 0;
        }
        public Player(int row, int col) : this()
        {
            Row = row;
            Col = col;
        }

        public int Col
        {
            get { return col; }
            set { col = value; }
        }
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public long StarsCollected
        {
            get { return starsCollected; }
            set { starsCollected = value; }
        }

        public static void MovePlayer(Player player)
        {
            while (player.Row >= 0 && player.Col < StartUp.board.Matrix.GetLength(1))
            {
                if (StartUp.board.IsInside(player.Row, player.Col))
                {
                    player.StarsCollected += StartUp.board.Matrix[player.Row, player.Col];
                }

                player.Col++;
                player.Row--;
            }
        }

        public static void MoveEnemy(Player evil)
        {
            while (evil.Row >= 0 && evil.Col >= 0)
            {
                if (StartUp.board.IsInside(evil.Row, evil.Col))
                {
                    StartUp.board.Matrix[evil.Row, evil.Col] = 0;
                }
                evil.Row--;
                evil.Col--;
            }
        }
    }
}
