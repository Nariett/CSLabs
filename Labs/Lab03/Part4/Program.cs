using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rez = 1;
            Console.WriteLine("Enter the number up to which you want to calculate the amount");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number x");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;i<=s;i++)
            {
                int f = factorial(i);
                rez += Math.Pow((2 * x), i) / f;
            }
            Console.WriteLine($"The result is {rez}");
            Console.ReadKey();

        }
        static int factorial(int n)
        {
            if (n == 1) return 1;
            return n * factorial(n - 1);
        }
    }
}
