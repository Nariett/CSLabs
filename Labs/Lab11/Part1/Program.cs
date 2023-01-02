using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b,c;
            Console.WriteLine("Введите катет A");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите катет B");
                b = Convert.ToInt32(Console.ReadLine());
                if(a == 0 || b == 0)
                {
                    throw new Exception();
                }
                c = Math.Sqrt(a * a + b * b);
                Console.WriteLine(c);
            }
            catch (Exception)
            {
                Console.WriteLine("Числа равны нулю");
            }
            Console.ReadKey();
        }
    }
}
