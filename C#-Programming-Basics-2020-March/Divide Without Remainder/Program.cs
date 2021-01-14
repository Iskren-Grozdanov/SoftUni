using System;

namespace For_Loop_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstGroup = 0;
            int secondGroup = 0;
            int thirdGroup = 0;

            for (int num = 1; num <= n; num++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    firstGroup++;
                }

                if (number % 3 == 0)
                {
                    secondGroup++;
                }

                if (number % 4 == 0)
                {
                    thirdGroup++;
                }
            }

            double p1 = firstGroup * 1.0 / n * 100;
            double p2 = secondGroup * 1.0 / n * 100;
            double p3 = thirdGroup * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}