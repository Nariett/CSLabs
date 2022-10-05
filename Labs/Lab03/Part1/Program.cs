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
            Console.WriteLine("Enter m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            int rez = 1;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    rez *= (int)Math.Pow(i,2);
                }
            }
            Console.WriteLine($"The result is {rez}");
            Console.ReadKey();
        }
    }
}
