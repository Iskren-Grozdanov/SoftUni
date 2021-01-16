using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int firstCommand = command[0];

                if (firstCommand == 1)
                {
                    int secondCommand = command[1];
                    stack.Push(secondCommand);
                }
                if (firstCommand == 2)
                {
                    stack.Pop();
                }
                if (firstCommand == 3 && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                if (firstCommand == 4 && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }

            }
            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
