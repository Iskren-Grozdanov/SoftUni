using System;
using System.Collections.Generic;
using System.Linq;
namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count>1)
            {
                
                int firstNum =int.Parse(stack.Pop());
                string sign = stack.Pop().ToString();
                int secondNum = int.Parse(stack.Pop());

                if (sign == "+")
                {
                    stack.Push((firstNum + secondNum).ToString());
                }
                else if (sign == "-")
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
