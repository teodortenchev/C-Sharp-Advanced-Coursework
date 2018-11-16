using System;
using System.Collections;
namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //the dimensions of the array are determined by the number of commas (,) + 1. Below is a two dimensional:
            //We cannot change the number of dimensions after creations but we can change the number of "rows" and "columns"
            int[,] intMatrix = new int[3, 4]; //this will be full of 0 
            //Three dimensional:
            string[,,] stringCube = new string[5, 5, 5]; //will initially be full of [Null]
            //A way to change the dimensions is to save it into a new array

            int[,] matrix =
            {
                {1, 2, 3, 4}, //row 0 values
                {5, 6, 7, 8} //row 1 values
            };
            //Getting element value:
            int[,] array = { { 1, 2 }, { 3, 4 } };
            int element11 = array[1, 1]; //element11 = 4

            int[,] sampleArray = new int[3, 4];

            //GetLength(0) get the 1st dimension Length.
            for (int row = 0; row < sampleArray.GetLength(0); row++)
            {
                for (int col = 0; col < sampleArray.GetLength(1); col++)
                {
                    sampleArray[row, col] = row + col;
                }
            }

            int[][] jagged = new int[5][];

            for (int row = 0; row < jagged.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split(' ');
                jagged[row] = new int[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(inputNumbers[col]);
                }


            }
        }
    }
}
