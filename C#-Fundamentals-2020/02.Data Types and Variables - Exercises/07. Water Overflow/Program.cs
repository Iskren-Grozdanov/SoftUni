using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            int totalWater = 0;

            for (int i = 0; i < inputLines; i++)
            {
                int currWater = int.Parse(Console.ReadLine());
                if (totalWater + currWater > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalWater += currWater;
                }
            }
            Console.WriteLine($"{totalWater}");
        }
    }
}
