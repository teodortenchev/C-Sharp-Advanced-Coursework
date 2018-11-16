using System;
using System.Linq;
namespace P1MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string[,] palindromeMatrix = new string[input[0], input[1]];



            for (int row = 0; row < palindromeMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < palindromeMatrix.GetLength(1); col++)
                {
                    for (int i = 0; i < palindromeMatrix.GetLength(1); i++)
                    {
                        //this will fill the palindromes
                        palindromeMatrix[row, col] = $"{alphabet[row]}{alphabet[row+col]}{alphabet[row]}";
                    }
                }
            }


            for (int i = 0; i < palindromeMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < palindromeMatrix.GetLength(1); j++)
                {
                    Console.Write($"{palindromeMatrix[i,j]} ");
                }
                Console.WriteLine();
            }


        }
    }
}
