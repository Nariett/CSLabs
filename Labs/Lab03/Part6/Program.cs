using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double i = -1; i <= 1.5;i+=0.1)
            {
                if (i > 1) Console.WriteLine($"x = {i} y = {1 + Math.Sqrt(Math.Cos(Math.Pow(i, 2) + 1))}");
                else
                {
                    if (0 <= i && i <= 1) Console.WriteLine($"x = {i} y = {-2 * i - Math.Pow(Math.Sin(i),2)}");
                    else
                    {
                        if (i < 0) Console.WriteLine($"x = {i} y = {Math.Pow(Math.E,Math.Pow(-Math.Cos(i),2))}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
