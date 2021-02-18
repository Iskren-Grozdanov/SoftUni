using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = item => Console.WriteLine($"Sir {string.Join(Environment.NewLine, item)}");

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(action);
        }
    }
}
