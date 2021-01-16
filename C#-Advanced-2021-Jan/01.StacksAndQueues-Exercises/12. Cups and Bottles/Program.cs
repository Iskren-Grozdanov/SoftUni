using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // cups - queue
            // bottles - stack

            int[] cupsCapacity = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] bottlesWithWater = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var cups = new Queue<int>(cupsCapacity);
            var bottles = new Stack<int>(bottlesWithWater);

            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                int currCup = cups.Peek();
                int currBottle = bottles.Peek();

                if (currBottle >= currCup)
                {
                    if (currCup - currBottle <= 0)
                    {
                        cups.Dequeue();
                    }
                    wastedWater += currBottle - currCup;
                    bottles.Pop();
                }
                else
                {
                    while (currCup > 0)
                    {
                        currCup -= bottles.Pop();
                    }
                    wastedWater += Math.Abs(currCup);
                    cups.Dequeue();
                }
            }
            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
