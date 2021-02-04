using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3

            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            foreach (var num in input)
            {
                if (!dictionary.ContainsKey(num))
                {
                    dictionary.Add(num, 0);
                }

                dictionary[num]++;
            }

            foreach (var (key, value) in dictionary)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
