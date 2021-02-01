using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int perople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int fullCourses = (int)Math.Ceiling((double)perople / capacity);
            Console.WriteLine(fullCourses);


        }
    }
}
