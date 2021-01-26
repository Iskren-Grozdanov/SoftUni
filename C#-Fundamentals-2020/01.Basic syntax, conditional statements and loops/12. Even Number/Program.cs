using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (currNum % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(currNum)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
