using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> Stack = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] cmdArg = command.Split();

                if (cmdArg[0] == "add")
                {
                    Stack.Push(int.Parse(cmdArg[1]));
                    Stack.Push(int.Parse(cmdArg[2]));
                }
                if (cmdArg[0] == "remove")
                {
                    var count = int.Parse(cmdArg[1]);

                    if (count <= Stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Sum: " + Stack.Sum());
        }
    }
}
