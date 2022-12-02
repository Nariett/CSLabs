using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Part1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            point q = new point(2, 2);
            Console.WriteLine($"Информация о точке\n{q.ToString()}");
            square a = new square(2, 3, 4, 5);
            Console.WriteLine($"Информация о квадрате\n{a.ToString()}");
            pyramid b = new pyramid(2, 3, 4, 5, 6, 7);
            Console.WriteLine($"Информация о пирамиде\n{b.ToString()}");
            Console.ReadKey();
        }
    }
}
