using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var text = new StringBuilder();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                int operation = int.Parse(command[0]);

                if (operation == 1)
                {
                    stack.Push(text.ToString());
                    string textToAppend = command[1];
                    text.Append(textToAppend);
                }
                else if (operation == 2)
                {
                    stack.Push(text.ToString());
                    int count = int.Parse(command[1]);
                    text.Remove(text.Length - count, count);
                }
                else if (operation == 3)
                {
                    int index = int.Parse(command[1]) - 1;
                    if (index >= 0 && index < text.Length)
                    {
                        Console.WriteLine(text[index]);
                    }
                }
                else if (operation == 4)
                {
                    text.Clear();
                    text.Append(stack.Pop());
                }
            }
        }
    }
}
