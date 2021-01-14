using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double full = row * columns;
            double price = -1;

            switch (type)
            {
                case "premiere": price = 12.00; break;
                case "normal": price = 7.50; break;
                case "discount": price = 5.00; break;

            }

            Console.WriteLine("{0:f2}", price * full);
        }
    }
}