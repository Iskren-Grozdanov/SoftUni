using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int km = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {num} and area {km} square km.");
        }
    }
}
