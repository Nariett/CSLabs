using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side c");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2))) || (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2))) || (Math.Pow(b, 2) == (Math.Pow(a, 2) + Math.Pow(c, 2))))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
