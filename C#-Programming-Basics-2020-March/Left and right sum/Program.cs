using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = int.Parse(Console.ReadLine());
                left += sum;
            }
            for (int i = 0; i < n; i++)
            {
                sum = int.Parse(Console.ReadLine());
                right += sum;
            }

            if (left == right)
                Console.WriteLine("Yes, sum = {0}", left);
            else Console.WriteLine("No, diff = {0}", Math.Abs(left - right));

        }
    }
}