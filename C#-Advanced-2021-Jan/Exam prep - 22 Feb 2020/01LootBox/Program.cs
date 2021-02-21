using System;
using System.Collections.Generic;
using System.Linq;

namespace _01LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue firstBox
            // Stack secondBox

            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int sum = 0;

            while (firstBox.Any() && secondBox.Any())
            {
                int itemFirstBox = firstBox.Peek();
                int itemSecondBox = secondBox.Peek();

                if ((itemFirstBox + itemSecondBox) % 2 == 0)
                {
                    int sumItems = itemFirstBox + itemSecondBox;
                    sum += sumItems;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    secondBox.Pop();
                    firstBox.Enqueue(itemSecondBox);
                }
            }

            if (!firstBox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (!secondBox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
