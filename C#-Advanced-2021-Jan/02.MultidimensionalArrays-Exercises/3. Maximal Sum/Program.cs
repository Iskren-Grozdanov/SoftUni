using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            FillsMatrix(matrix);

            int maxSum = int.MinValue;
            int indexOfRow = int.MinValue;
            int indexOfCol = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        indexOfRow = row;
                        indexOfCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[indexOfRow,indexOfCol]} {matrix[indexOfRow, indexOfCol+1]} {matrix[indexOfRow, indexOfCol+2]}");
            Console.WriteLine($"{matrix[indexOfRow+1,indexOfCol]} {matrix[indexOfRow+1, indexOfCol+1]} {matrix[indexOfRow+1, indexOfCol+2]}");
            Console.WriteLine($"{matrix[indexOfRow+2,indexOfCol]} {matrix[indexOfRow+2, indexOfCol+1]} {matrix[indexOfRow+2, indexOfCol+2]}");


        }

        private static void FillsMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
