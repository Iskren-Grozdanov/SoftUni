using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            int evenCounter = 0;
            int oddCounter = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num >= evenMax)
                    {
                        evenMax = num;
                    }
                    if (num <= evenMin)
                    {
                        evenMin = num;
                    }
                    evenCounter++;
                }
                else
                {
                    oddSum += num;
                    if (num >= oddMax)
                    {
                        oddMax = num;
                    }
                    if (num <= oddMin)
                    {
                        oddMin = num;
                    }
                    oddCounter++;
                }
            }

            if (oddCounter > 0)
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            else
            {
                Console.WriteLine("OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            if (evenCounter > 0)
            {
                Console.WriteLine($"EvenSum={evenSum:F2},");
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
            else
            {
                Console.WriteLine($"EvenSum=0.00,");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}