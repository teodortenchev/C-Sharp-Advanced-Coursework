using System;
using System.Linq;

namespace P6JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[matrixRows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] numbersFill = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                jagged[row] = numbersFill;
                
            }

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        int row = int.Parse(tokens[1]);
                        int col = int.Parse(tokens[2]);
                        int value = int.Parse(tokens[3]);

                        if ((row >= 0 && col >= 0) && (row < jagged.Length && col < jagged[row].Length))
                        {
                            jagged[row][col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;

                    case "Subtract":
                        row = int.Parse(tokens[1]);
                        col = int.Parse(tokens[2]);
                        value = int.Parse(tokens[3]);

                        if ((row >= 0 && col >=0) && (row < jagged.Length && col < jagged[row].Length))
                        {
                            jagged[row][col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;

                    case "END":
                        PrintJaggedArray(jagged);
                        return;

                    default:
                        Console.WriteLine("Wrong command given.");
                        break;
                }
            }

        }

        static void PrintJaggedArray(int[][] jagged)
        {

            foreach (int[] row in jagged)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
