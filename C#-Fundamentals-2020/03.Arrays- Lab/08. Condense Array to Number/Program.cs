using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] firstLength = new int[originalArray.Length - 1];

            int finalResult = 0;

            if (originalArray.Length == 1)
            {
                Console.WriteLine(originalArray[0]);
            }
            else
            {
                for (int i = 0; i < firstLength.Length; i++)
                {

                    int[] condensed = new int[originalArray.Length - 1];
                    for (int j = 0; j < condensed.Length; j++)
                    {
                        condensed[j] = originalArray[j] + originalArray[j + 1];
                    }
                    originalArray = condensed;
                    finalResult = condensed[0];
                }
                Console.WriteLine(finalResult);
            }




        }
    }
}