using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> PrintOnNewLine = item => Console.WriteLine(string.Join(Environment.NewLine, item));

            string[] words = Console.ReadLine()
                .Split();

            PrintOnNewLine(words);
        }
    }
}
