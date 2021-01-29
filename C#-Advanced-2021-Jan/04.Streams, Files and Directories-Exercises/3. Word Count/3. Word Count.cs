using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Streams__files_and_directories_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsPath = "data/words.txt";
            string textPath = "data/text.txt";

            string[] words = File.ReadAllLines(wordsPath);
            string[] Lines = File.ReadAllLines(textPath);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordLower = word.ToLower();

                if (!dictionary.ContainsKey(wordLower))
                {
                    dictionary.Add(wordLower, 0);
                }
            }

            foreach (var line in Lines)
            {
                string[] currLine = line
                    .ToLower()
                    .Split(new char[] { ' ', '-', ',', '!', '?', '.', '\'' });

                foreach (var currWord in currLine)
                {
                    if (dictionary.ContainsKey(currWord))
                    {
                        dictionary[currWord]++;
                    }
                }
            }

            string actualPath = "data/actualResult.txt";
            string expectedResult = "data/expectedResult.txt";

            foreach (var item in dictionary)
            {
                File.AppendAllText(actualPath, $"{item.Key} - {item.Value}{Environment.NewLine}");
            }

            foreach (var item in dictionary.OrderByDescending(e => e.Value))
            {
                File.AppendAllText(expectedResult, $"{item.Key} - {item.Value}{Environment.NewLine}");
            }
        }
    }
}
