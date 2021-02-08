using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int SecondNum = int.Parse(Console.ReadLine());
            int ThirdNum = int.Parse(Console.ReadLine());

            PrintBiggest(firstNum, SecondNum, ThirdNum);

        }

        static void PrintBiggest(int firstNum, int secondNum, int thirdNum)
        {
            int larger = 0;
            if (firstNum <= secondNum && firstNum <= thirdNum)
            {
                larger = firstNum;
            }
            else if (secondNum <= firstNum && secondNum <= thirdNum)
            {
                larger = secondNum;
            }
            else if (thirdNum <= firstNum && thirdNum <= secondNum)
            {
                larger = thirdNum;
            }
            Console.WriteLine(larger);
        }
    }
}
