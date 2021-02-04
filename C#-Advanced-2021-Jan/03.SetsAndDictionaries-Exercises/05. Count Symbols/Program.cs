using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            foreach (var symbol in input)
            {
                if (!dictionary.ContainsKey(symbol))
                {
                    dictionary.Add(symbol,0);
                }
                dictionary[symbol]++;
            } 

            foreach (var (symbol, times) in dictionary)
            {
                Console.WriteLine($"{symbol}: {times} time/s");
            }
        }
    }
}
