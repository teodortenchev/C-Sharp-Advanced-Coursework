using System;
using System.Collections.Generic;
using System.Text;

namespace P06_Sneaking
{
    public class Room
    {
        public Room (int rows)
        {
            InitializeRoom(rows);
            Length = this.PlayField.Length;
        }

        public char[][] PlayField { get; set; }
        public int Length { get; set; }

        private void InitializeRoom(int rows)
        {
            PlayField = new char[rows][];
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                PlayField[row] = new char[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    PlayField[row][col] = input[col];
                }
            }
        }
    }
}
