using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int start = 1; start <= 10; start++)
            {
                sum = start * number;
                Console.WriteLine($"{number} X {start} = {sum}");
            }
        }
    }
}
