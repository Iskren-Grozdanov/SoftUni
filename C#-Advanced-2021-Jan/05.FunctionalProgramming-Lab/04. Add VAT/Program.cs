using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => {
                    decimal num = decimal.Parse(e);     // .Select(e => e * 1.2)
                    return num * 1.2M;
                    })
                .ToList()
                .ForEach(e => Console.WriteLine($"{e:f2}"));
        }
    }
}
