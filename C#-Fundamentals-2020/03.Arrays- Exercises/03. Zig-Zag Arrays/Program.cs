using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] array1 = new string[n];
            string[] array2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currArray = Console.ReadLine()
                    .Split();

                if (i % 2 == 0)
                {
                    array1[i] = currArray[0];
                    array2[i] = currArray[1];
                }
                else
                {
                    array1[i] = currArray[1];
                    array2[i] = currArray[0];
                }
            }
            Console.WriteLine(String.Join(" ", array1));
            Console.WriteLine(String.Join(" ", array2));
        }
    }
}
