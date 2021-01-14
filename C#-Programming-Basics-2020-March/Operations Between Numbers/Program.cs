using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            double result = 0;
            string evenOrOdd = "";

            if (operation == '+')
            {
                result = firstNumber + secondNumber;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
            }

            else if (operation == '-')
            {
                result = firstNumber - secondNumber;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
            }

            else if (operation == '*')
            {
                result = firstNumber * secondNumber;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
            }

            else if (operation == '/')
            {
                result = firstNumber / secondNumber;
            }

            else if (operation == '%')
            {
                result = firstNumber % secondNumber;
            }

            if (operation == '+' || operation == '-' || operation == '*')
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result} - {evenOrOdd}");
            }

            else if (operation == '/')
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }

                else
                {
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result:f2}");
                }
            }

            else if (operation == '%')
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }

                else
                {
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                }
            }
        }
    }
}