using System;
using System.Linq;

namespace MultidimensionalArraysPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] firstArray = new int[rows][];
            int[][] secondArray = new int[rows][];

            FillArrays(firstArray, secondArray);

            int[][] legoBlock = new int[rows][];

            bool fullMatch = CheckLegoFit(firstArray,secondArray,legoBlock);
            
            if (fullMatch)
            {
                for (int row = 0; row < legoBlock.Length; row++)
                {
                    int[] joinedRow = firstArray[row].Concat(secondArray[row]).ToArray();
                    legoBlock[row] = joinedRow;
                }
                PrintResultMatrix(legoBlock);
            }
            else
            {
                Console.WriteLine("The total number of cells is: " + CountCells(firstArray,secondArray));
            }

           

            
        }

        private static int CountCells(int[][] firstArray, int[][] secondArray)
        {
            int count = 0;

            for (int row = 0; row < firstArray.Length; row++)
            {
                count += firstArray[row].Length + secondArray[row].Length;
            }

            return count;
        }

        private static void PrintResultMatrix(int[][] legoBlock)
        {
            foreach (int[] row in legoBlock)
            {
                Console.WriteLine("[" + String.Join(", ", row) + "]");
            }
        }

        private static bool CheckLegoFit(int[][] firstArray, int[][] secondArray, int[][] legoBlock)
        {
           
            for (int row = 0; row < legoBlock.Length - 1; row++)
            {
                int rowLength = firstArray[row].Length + secondArray[row].Length;
                int nextLength = firstArray[row + 1].Length + secondArray[row + 1].Length;

                if (rowLength != nextLength)
                {
                    return false;
                }
            }

            return true;
        }

        private static void FillArrays(int[][] firstArray, int[][] secondArray)
        {
            for (int row = 0; row < firstArray.Length; row++)
            {
                int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                firstArray[row] = numbers;
            }

            for (int row = 0; row < secondArray.Length; row++)
            {
                int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse()
                    .Select(int.Parse).ToArray();
                
                secondArray[row] = numbers;
            }

            
        }


    }
}
