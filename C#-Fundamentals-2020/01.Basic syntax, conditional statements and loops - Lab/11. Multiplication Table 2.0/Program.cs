using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int sum = 0;

            if (second > 10)
            {
                Console.WriteLine($"{first} X {second} = {first * second}");
            }
            else
            {
                for (; second <= 10; second++)
                {
                    sum = second * first;
                    Console.WriteLine($"{first} X {second} = {sum}");
                }

            }
        }
    }
}
