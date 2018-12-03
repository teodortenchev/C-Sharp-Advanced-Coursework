namespace P03_JediGalaxy
{
    public class Board
    {
        private int[,] matrix;

        public Board(int rows, int cols)
        {
            this.Matrix = new int[rows, cols];
            this.InitializeMatrix();
        }
        public int[,] Matrix { get => matrix; set => matrix = value; }

        private void InitializeMatrix()
        {
            int value = 0;

            for (int i = 0; i < this.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = value++;
                }
            }
        }

        public bool IsInside(int row, int col)
        {
            return row >= 0 && row < Matrix.GetLength(0) && col >= 0 && col < Matrix.GetLength(1);
        }
    }
}
