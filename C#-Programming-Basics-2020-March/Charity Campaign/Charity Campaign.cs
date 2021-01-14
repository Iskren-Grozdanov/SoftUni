using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_charity_campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int sladkari = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gof = int.Parse(Console.ReadLine());
            int pal = int.Parse(Console.ReadLine());

            double cakesPrice = 45.0 * cakes * sladkari * days;
            double gofPrice = 5.80 * gof * sladkari * days;
            double palPrice = 3.20 * pal * sladkari * days;
            double totalPrice = cakesPrice + gofPrice + palPrice;

            double costs = totalPrice / 8;
            double sum = totalPrice - costs;

            Console.WriteLine(sum);
        }
    }
}