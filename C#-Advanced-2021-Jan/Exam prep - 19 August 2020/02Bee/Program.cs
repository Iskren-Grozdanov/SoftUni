using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int beeRow = 0;
            int beeCol = 0;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            string command = Console.ReadLine();
            int polinatedFlowers = 0;

            while (command != "End")
            {
                matrix[beeRow, beeCol] = '.';
                //beeRow = MoveRow(beeRow, command);
                //beeCol = MoveCol(beeCol, command);

                switch (command)
                {
                    case "up":
                        beeRow--;
                        break;
                    case "down":
                        beeRow++;
                        break;
                    case "left":
                        beeCol--;
                        break;
                    case "right":
                        beeCol++;
                        break;
                }

                if (!IsValid(beeRow, beeCol, n, n))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if (matrix[beeRow, beeCol] == 'f')
                {
                    polinatedFlowers++;
                }
                if (matrix[beeRow, beeCol] == 'O')
                {
                    matrix[beeRow, beeCol] = '.';

                    //beeRow = MoveRow(beeRow, command);
                    //beeCol = MoveCol(beeCol, command);

                    switch (command)
                    {
                        case "up":
                            beeRow--;
                            break;
                        case "down":
                            beeRow++;
                            break;
                        case "left":
                            beeCol--;
                            break;
                        case "right":
                            beeCol++;
                            break;
                    }

                    if (!IsValid(beeRow, beeCol, n, n))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                    if (matrix[beeRow, beeCol] == 'f')
                    {
                        polinatedFlowers++;
                    }
                }

                matrix[beeRow, beeCol] = 'B';
                command = Console.ReadLine();
            }

            if (polinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinatedFlowers} flowers more");
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        //public static int MoveRow(int row, string movement)
        //{
        //    if (movement == "up")
        //    {
        //        return row - 1;
        //    }
        //    else if (movement == "down")
        //    {
        //        return row + 1;
        //    }
        //    return row;
        //}

        //public static int MoveCol(int col, string movement)
        //{
        //    if (movement == "right")
        //    {
        //        return col + 1;
        //    }
        //    else if (movement == "left")
        //    {
        //        return col - 1;
        //    }
        //    return col;
        //}

        public static bool IsValid(int beeRow, int beeCol, int rows, int cols)
        {
            if (beeRow < 0 || beeRow >= rows)
            {
                return false;
            }
            if (beeCol < 0 || beeCol >= cols)
            {
                return false;
            }
            return true;
        }
    }
}
