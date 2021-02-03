using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text1 = Console.ReadLine().Split(" ");
            string[] text2 = Console.ReadLine().Split(" ");

            foreach (string item in text2)
            {

                foreach (string item2 in text1)
                {
                    if (item == item2)
                    {

                        Console.Write(item + " ");
                        break;

                    }
                }
            }


        }
    }
}
