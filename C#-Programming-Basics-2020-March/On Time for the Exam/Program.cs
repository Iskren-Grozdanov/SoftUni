using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minArrive = int.Parse(Console.ReadLine());
            int obMinExam = hourExam * 60 + minExam;
            int obMinArrive = hourArrive * 60 + minArrive;
            if (obMinExam == obMinArrive || (obMinExam > obMinArrive && obMinExam - obMinArrive <= 30))
            {
                Console.WriteLine("On time");
            }
            if (obMinExam > obMinArrive && obMinExam - obMinArrive > 30)
            {
                Console.WriteLine("Early");
            }
            if (obMinArrive > obMinExam)
            {
                Console.WriteLine("Late");
            }
            if (Math.Abs(obMinArrive - obMinExam) != 0)
            {
                var hours = Math.Abs(obMinArrive - obMinExam) / 60;
                var mins = Math.Abs(obMinArrive - obMinExam) % 60;
                if (hours >= 1)
                {
                    if (mins < 10) Console.Write(hours + ":0" + mins + " hours");
                    else Console.Write(hours + ":" + mins + " hours");
                }
                else Console.Write(mins + " minutes");
                if ((obMinArrive - obMinExam) < 0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");
            }
        }
    }
}