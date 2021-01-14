using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string sezonName = Console.ReadLine();
            int fisherManCount = int.Parse(Console.ReadLine());
            double rent = 0;
            double discount = 0;

            switch (sezonName)
            {
                case "Spring":
                    rent = 3000;
                    if (fisherManCount >= 12)
                    {
                        discount = rent * 0.25;
                        rent -= discount;
                    }
                    else if (fisherManCount >= 7 && fisherManCount <= 11)
                    {
                        discount = rent * 0.15;
                        rent -= discount;
                    }
                    else
                    {
                        discount = rent * 0.10;
                        rent -= discount;
                    }

                    if (fisherManCount % 2 == 0)
                    {
                        discount = rent * 0.05;
                        rent -= discount;
                    }
                    else
                    {
                        rent = rent;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    rent = 4200;
                    if (fisherManCount >= 12)
                    {
                        discount = rent * 0.25;
                        rent -= discount;
                    }
                    else if (fisherManCount >= 7 && fisherManCount <= 11)
                    {
                        discount = rent * 0.15;
                        rent -= discount;
                    }
                    else
                    {
                        discount = rent * 0.10;
                        rent -= discount;
                    }

                    if (fisherManCount % 2 == 0 && sezonName != "Autumn")
                    {
                        discount = rent * 0.05;
                        rent -= discount;
                    }
                    else
                    {
                        rent = rent;
                    }
                    break;
                case "Winter":
                    rent = 2600;
                    if (fisherManCount >= 12)
                    {
                        discount = rent * 0.25;
                        rent -= discount;
                    }
                    else if (fisherManCount >= 7 && fisherManCount <= 11)
                    {
                        discount = rent * 0.15;
                        rent -= discount;
                    }
                    else
                    {
                        discount = rent * 0.10;
                        rent -= discount;
                    }

                    if (fisherManCount % 2 == 0)
                    {
                        discount = rent * 0.05;
                        rent -= discount;
                    }
                    else
                    {
                        rent = rent;
                    }
                    break;
            }
            double totalPrice = Math.Abs(groupBudget - rent);

            if (rent <= groupBudget)
            {
                Console.WriteLine($"Yes! You have {totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice:f2} leva.");
            }
        }
    }
}