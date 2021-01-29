using System;
using System.IO;
using System.Linq;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("data/text.txt");

            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int countOfLetter = CountOfLetters(line);
                int countOfMarks = CountOfPunctuationMarks(line);

                result[i] = $"Line {i + 1}: {lines[i]} ({countOfLetter})({countOfMarks})";
            }
            File.WriteAllLines("data/output.txt", result);
        }

        static int CountOfLetters(string line)
        {
            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (Char.IsLetter(currentSymbol))
                {
                    counter++;
                }
            }
            return counter;
        }

        static int CountOfPunctuationMarks(string line)
        {
            char[] punctuationMarks = { '-', ',', '.', '!', '?', '\'' };
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];

                if (punctuationMarks.Contains(currentSymbol))

                    counter++;
            }

            return counter;
        }
    }
}

