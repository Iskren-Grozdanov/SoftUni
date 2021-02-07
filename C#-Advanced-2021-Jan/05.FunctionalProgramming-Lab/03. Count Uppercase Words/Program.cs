using System;
using System.Linq;

namespace _03CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> CapitalChecker = str => str[0] == str.ToUpper()[0];

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => CapitalChecker(x))
                .ToList()
                .ForEach(x => Console.WriteLine(x));   
        }
    }
}