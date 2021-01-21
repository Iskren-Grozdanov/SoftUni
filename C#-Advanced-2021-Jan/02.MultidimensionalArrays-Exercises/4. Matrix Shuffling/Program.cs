using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[size[0], size[1]];

            FillsMatrix(matrix);



        }

        private static void FillsMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
