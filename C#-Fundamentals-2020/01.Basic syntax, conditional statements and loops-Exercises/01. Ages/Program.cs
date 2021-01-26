using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string name = "";
            if (age < 0)
            {

            }
            else if (age <= 2)
            {
                name = "baby";
            }
            else if (age > 2 && age <= 13)
            {
                name = "child";
            }
            else if (age > 13 && age <= 19)
            {
                name = "teenager";
            }
            else if (age > 19 && age <= 65)
            {
                name = "adult";
            }
            else if (age > 65)
            {
                name = "elder";
            }
            Console.WriteLine(name);
        }
    }
}
