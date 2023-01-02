using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        delegate void Func(double s,double f,double d);
        static void SinH(double s, double f, double d)
        {
            for (double i = s; i < f; i += d)
            {
                Console.WriteLine($"x = {i} y = {Math.Sinh(i)}");
            }
        }
        static void Ctg(double s, double f, double d)
        {
            for (double i = s; i < f; i += d)
            {
                Console.WriteLine($"x = {i} y = {1.0 / Math.Tan(i)}");
            }
        }
        static void Main(string[] args)
        {
            Func sinh = new Func(SinH);
            sinh(-4, 0, 0.4);
            Func ctg = new Func(Ctg);
            ctg(-4, 0, 0.4);
            Console.ReadKey();
        }
    }
}
