using System;
using System.Collections.Generic;
using System.Linq;

namespace P2
{
    class Program
    {
        static char[,] matrix;
        static int ships1;
        static int ships2;
        static int total;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> cmd = new List<string>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries));

            matrix = new char[n, n];

            int countAttacts = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] input = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (input[j] == '<')
                    {
                        ships1++;
                    }
                    if (input[j] == '>')
                    {
                        ships2++;
                    }
                    matrix[i, j] = input[j];
                }
            }
            while (cmd.Count > 0)
            {
                countAttacts++;
                int row;
                int col;

                if (countAttacts % 2 != 0)
                {
                    int[] coordinates = cmd[0].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    row = coordinates[0];
                    col = coordinates[1];

                    if (!IsPositionInMatrix(row, col))
                    {
                        cmd.RemoveAt(0);
                        continue;
                    }
                    MovePlayerOne(matrix, row, col);
                }
                else
                {
                    int[] coordinates = cmd[0].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    row = coordinates[0];
                    col = coordinates[1];

                    if (!IsPositionInMatrix(row, col))
                    {
                        cmd.RemoveAt(0);
                        continue;
                    }

                    MovePlayerTwo(matrix, row, col);
                }

                if (ships1 == 0 || ships2 == 0)
                {
                    if (ships1 == 0)
                    {
                        Console.WriteLine($"Player Two has won the game! {total} ships have been sunk in the battle.");
                    }
                    if (ships2 == 0)
                    {
                        Console.WriteLine($"Player One has won the game! {total} ships have been sunk in the battle.");
                    }
                    Environment.Exit(0);
                }

                cmd.RemoveAt(0);

            }

            Console.WriteLine($"It's a draw! Player One has {ships1} ships left. Player Two has {ships2} ships left.");
        }

        private static void MovePlayerOne(char[,] matrix, int rowToGo, int colToGo)
        {
            if (matrix[rowToGo, colToGo] == '#')
            {
                matrix[rowToGo, colToGo] = 'X';
                Mine(rowToGo, colToGo);
            }

            else if (matrix[rowToGo, colToGo] == '>')
            {
                ships2--;
                matrix[rowToGo, colToGo] = 'X';
                total++;
            }

        }
        private static void MovePlayerTwo(char[,] matrix, int rowToGo, int colToGo)
        {


            if (matrix[rowToGo, colToGo] == '#')
            {
                matrix[rowToGo, colToGo] = 'X';
                Mine(rowToGo, colToGo);
            }

            else if (matrix[rowToGo, colToGo] == '<')
            {
                ships1--;
                matrix[rowToGo, colToGo] = 'X';
                total++;
            }
        }

        static void Mine(int row, int col)
        {
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (IsPositionInMatrix(i, j))
                    {
                        if (matrix[i, j] == '<')
                        {
                            ships1--;
                            matrix[i, j] = 'X';
                            total++;
                        }
                        else if (matrix[i, j] == '>')
                        {
                            ships2--;
                            matrix[i, j] = 'X';
                            total++;
                        }

                    }

                }

            }
        }

        private static bool IsPositionInMatrix(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
