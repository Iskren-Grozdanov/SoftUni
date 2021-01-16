using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 начин

            //char[] input = Console.ReadLine().ToCharArray();
            //Stack<char> = ReversedStack = new Stack<char>(input);

            //---------------

            // 1 начин
            string input = Console.ReadLine();
            Stack<char> ReversedStack = new Stack<char>();
            //--------------
            for (int i = 0; i < input.Length; i++)
            {
                ReversedStack.Push(input[i]);
            }

            while (ReversedStack.Count > 0)
            {
                Console.Write(ReversedStack.Pop());
            }
        }
    }
}
