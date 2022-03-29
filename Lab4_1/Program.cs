using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle a = new Angle();
            a.Read();
            Console.WriteLine("");
            a.Display();
            Console.WriteLine("");
            Console.WriteLine("Results: ");
            Console.WriteLine("Radians: " + a.Radian());
            Console.WriteLine("Sinus: " + a.Sin());
            Console.WriteLine("");
            a.Minus();
            a.Display();
            Console.WriteLine("");
            a.Plus();
            a.Display();
            Console.WriteLine("");
            Console.WriteLine("Results: ");
            Console.WriteLine("Radians: " + a.Radian());
            Console.WriteLine("Sinus: " + a.Sin());
            Console.ReadKey();
        }
    }
}
