using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            figura a = new figura(2);
            Console.WriteLine(a.ToString());
            rectangle b = new rectangle(2, 2);
            Console.WriteLine(b.ToString());
            Console.WriteLine($"Периметр прямоугольника = {b.Perim()}");
            circle c = new circle(2, 2);
            Console.WriteLine(c.ToString());
            Console.WriteLine($"Периметр круга = {c.Perim()}");
            trapezoid d = new trapezoid(2, 3, 4, 5);
            Console.WriteLine(d.ToString());
            Console.WriteLine($"Периметр трапеции = {d.Perim()}");
            Console.ReadKey();
        }
    }
}
