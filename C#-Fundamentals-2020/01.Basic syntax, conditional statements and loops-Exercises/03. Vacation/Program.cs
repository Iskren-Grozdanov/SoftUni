using System;
using System.Security.Principal;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typePeople = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (typePeople)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        price = 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        price = 10.46;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        price = 16;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15;
                    }
                    else if (day == "Saturday")
                    {
                        price = 20;
                    }
                    else if (day == "Sunday")
                    {
                        price = 22.50;
                    }
                    break;
            }

            double totalPrice = 0;


            if (typePeople == "Business" && people >= 100)
            {

                people -= 10;
                totalPrice = price * people;

            }
            else
            {
                totalPrice = price * people;
            }

            if (typePeople == "Students" && people >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (typePeople == "Business" && people >= 100)
            {
                totalPrice *= 0.9;
            }
            else if (typePeople == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
