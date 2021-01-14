using System;

namespace _04._NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (flowers == "Roses")
            {
                totalPrice = count * 5;
                if (count > 80)
                {
                    totalPrice -= totalPrice * 0.1;
                }
            }
            else if (flowers == "Dahlias")
            {
                totalPrice = count * 3.80;
                if (count > 90)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                totalPrice = count * 2.80;
                if (count > 80)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                totalPrice = count * 3;
                if (count < 120)
                {
                    totalPrice += totalPrice * 0.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                totalPrice = count * 2.5;
                if (count < 80)
                {
                    totalPrice += totalPrice * 0.2;
                }
            }

            if (budget >= totalPrice)
            {
                double remaining = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {remaining:f2} leva left.");
            }
            else
            {
                double missing = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {missing:f2} leva more.");
            }
        }
    }
}