using System;
using System.Linq;

namespace _02Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];

            FillsMatrix(matrix);

            string command = Console.ReadLine();

            while (command != "Bloom Bloom Plow")
            {
                string[] rowsAndCols = command.Split();
                int plantRow = int.Parse(rowsAndCols[0]);
                int plantCol = int.Parse(rowsAndCols[1]);

                if (!IsPositionValid(plantRow, plantCol, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (plantRow == row || plantCol == col)
                        {
                            matrix[row, col] += 1;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            PrintsMatrix(matrix);
        }

        private static void PrintsMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillsMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }
        }

        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }
    }
}
