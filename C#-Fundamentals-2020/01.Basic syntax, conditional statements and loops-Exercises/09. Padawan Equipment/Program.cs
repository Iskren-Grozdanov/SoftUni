using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            double allMoney = 0;
            int freeBelt = 0;

            double numberLighsaber = Math.Ceiling(students * 1.1);

            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelt++;
                }
            }


            allMoney = priceLightsaber * numberLighsaber + priceRobe * students + priceBelt * (students - freeBelt);

            if (budget >= allMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {allMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {allMoney - budget:f2}lv more.");
            }
        }
    }
}
