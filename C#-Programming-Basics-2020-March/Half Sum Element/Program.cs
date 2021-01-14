using System;

namespace ConsoleApp1дасдасдасд
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                if (numbers > max)
                {
                    max = numbers;
                }
            }
            int sumWithoutMax = sum - max;
            if (sumWithoutMax == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - sumWithoutMax)}");
            }

        }
    }
}
