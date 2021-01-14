using System;

namespace ToyShop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            //price excursion
            double priceExcursion = double.Parse(Console.ReadLine());
            //amount of toys
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            //sum toys
            int allToys = puzzles + dolls + bears + minions + trucks;
            double income = 0;
            income += puzzles * 2.60;
            income += dolls * 3.00;
            income += bears * 4.10;
            income += minions * 8.20;
            income += trucks * 2.00;

            //discount if 50 or more
            if (allToys >= 50)
            {
                income *= 0.75;
            }
            //rent
            income *= 0.90;
            //final output
            double remaining = income - priceExcursion;
            double needed = priceExcursion - income;
            if (income >= priceExcursion)
            {
                Console.WriteLine($"Yes! {remaining:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {needed:f2} lv needed.");
            }
        }
    }
}
