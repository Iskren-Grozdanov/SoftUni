using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader file = new StreamReader(@"data\text.txt"))
            {
                string line = file.ReadLine();

                int counter = 0;

                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        Regex pattern = new Regex("[-,.!?]");
                        line = pattern.Replace(line, "@");
                        var array = line.Split().ToArray().Reverse();
                        Console.WriteLine(string.Join(" ", array));
                    }
                    counter++;

                    line = file.ReadLine();
                }
            }
        }
    }
}
