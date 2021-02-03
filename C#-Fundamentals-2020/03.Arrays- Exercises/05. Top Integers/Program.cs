using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                int curr = array[i];
                bool isTopInteger = true;

                for (int index = i + 1; index < array.Length; index++)
                {
                    if (curr <= array[index])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    result += curr + " ";
                }
            }

            Console.WriteLine(result);
        }
    }
}
