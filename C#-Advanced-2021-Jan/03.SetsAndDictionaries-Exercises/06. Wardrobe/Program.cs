using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {                                            //[0]          //[1]
                string[] Split = Console.ReadLine() //Blue -> dress,jeans,hat
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string color = Split[0];

                string[] clothes = Split[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!dictionary.ContainsKey(color))
                {
                    dictionary.Add(color,new Dictionary<string, int>());
                }

                foreach (var item in clothes)
                {
                    if (!dictionary[color].ContainsKey(item))
                    {
                        dictionary[color].Add(item, 0);
                    }
                    dictionary[color][item]++;
                }
            }

            string[] lookedClothes = Console.ReadLine().Split();

            foreach (var (color, clothes) in dictionary)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var (cloth, number) in clothes)
                {
                    if (color == lookedClothes[0] && cloth == lookedClothes[1])
                    {
                        Console.WriteLine($"* {cloth} - {number} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {cloth} - {number}");

                }
            }
        }
    }
}
