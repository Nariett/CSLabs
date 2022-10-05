using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter h");
            double h = Convert.ToDouble(Console.ReadLine());
            fun(a, b, h);
            Console.ReadKey();

        }
        static void fun(double a,double b,double h)
        {
            for(double i = a;i <= b;i+=h)
            {
                Console.WriteLine($"x = {i}, y = {(1 - (Math.Pow(i, 2) / 4)) * Math.Cos(i - (i / 2) * Math.Sin(i))}");
            }
        }
    }
}
