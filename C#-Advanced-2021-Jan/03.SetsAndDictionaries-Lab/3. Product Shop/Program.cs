using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> dictionary = new Dictionary<string, Dictionary<string, double>>();


            while (input != "Revision")
            {
                string[] inputArgs = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string market = inputArgs[0];
                string item = inputArgs[1];
                double price = double.Parse(inputArgs[2]);

                if (!dictionary.ContainsKey(market))
                {
                    dictionary.Add(market, new Dictionary<string, double>());
                }

                dictionary[market].Add(item, price);

                input = Console.ReadLine();
            }

            foreach (var (market, itemsAndPrice) in dictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{market}->");

                foreach (var (item, price) in itemsAndPrice)
                {
                    Console.WriteLine($"Product: {item}, Price: {price}");
                }
            }
        }
    }
}
