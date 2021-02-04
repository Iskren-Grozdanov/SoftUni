using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //7
            //Ivancho 5.20
            //Mariika 5.50
            //Ivancho 3.20
            //Mariika 2.50
            //Stamat 2.00
            //Mariika 3.46
            //Stamat 3.00

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> dictionary = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, new List<decimal>());
                }

                dictionary[name].Add(grade);
            }

            foreach (var (nameKey, gradeValue) in dictionary)
            {
                Console.Write($"{nameKey} -> ");

                foreach (var item in gradeValue)
                {
                    Console.Write($"{item:F2} ");
                }

                Console.WriteLine($"(avg: {gradeValue.Average():f2})");
            }

        }
    }
}
