using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstSetLength = input[0];
            int secondSetLength = input[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLength; i++)
            {
                int num = int.Parse(Console.ReadLine());

                firstSet.Add(num);
            }

            for (int i = 0; i < secondSetLength; i++)
            {
                int num = int.Parse(Console.ReadLine());

                secondSet.Add(num);
            }

            HashSet<int> intersection = firstSet.Intersect(secondSet).ToHashSet();

            Console.WriteLine(string.Join(" ", intersection));
        }
    }
}
