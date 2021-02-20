using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Queue - liquids
            //2 Stack - ingredients

            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int sum = 0;
            int bread = 0;
            int cake = 0;
            int pastry = 0;
            int fruitPie = 0;

            while (liquids.Any() && ingredients.Any())
            {
                int liquid = liquids.Dequeue();
                int ingredient = ingredients.Pop();
                sum = liquid + ingredient;

                if (sum == 25)
                {
                    bread++;
                }
                else if (sum == 50)
                {
                    cake++;
                }
                else if (sum == 75)
                {
                    pastry++;
                }
                else if (sum == 100)
                {
                    fruitPie++;
                }
                else
                {
                    sum -= liquid;
                    sum += 3;
                    ingredients.Push(sum);
                }
            }

            if (bread > 0 && cake > 0 && pastry > 0 && fruitPie > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (!liquids.Any())
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }

            if (!ingredients.Any())
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }

            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");
        }
    }
}
