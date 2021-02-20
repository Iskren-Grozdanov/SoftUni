using System;
using System.Collections.Generic;
using System.Linq;

namespace _01FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int wreaths = 0;
            int remainingFlowers = 0;

            while (lilies.Any() && roses.Any())
            {
                int lilie = lilies.Pop();
                int rose = roses.Dequeue();

                int sum = lilie + rose;

                if (sum == 15)
                {
                    wreaths++;
                }
                else if (sum < 15)
                {
                    remainingFlowers += sum;
                }
                else
                {
                    while (sum > 15)
                    {
                        sum -= 2;
                        if (sum == 15)
                        {
                            wreaths++;
                        }
                        else if (sum < 15)
                        {
                            remainingFlowers += sum;
                        }
                    }
                }
            }

            int remainingWreaths = Math.Abs(remainingFlowers / 15);
            wreaths += remainingWreaths;

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
