using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(input))
                {
                    dictionary.Add(input, 0);
                }
                dictionary[input]++;
            }

            //dictionary.Where(x => x.Value % 2 == 0).FirstOrDefault().Key;

            foreach (var num in dictionary)
            {
                if (num.Value%2==0)
                {
                    Console.WriteLine(num.Key);
                }
            }
        }
    }
}
