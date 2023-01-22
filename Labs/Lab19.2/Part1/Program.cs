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
            int[] x = new int[] { 1, 2, 3, 4};
            int[] q = new int[] { 1, 2, 3, 5 };
            DoubleArr<int> z = new DoubleArr<int>(x);
            Console.WriteLine($"Массив 1: {z.ToString()}");
            DoubleArr<int> w = new DoubleArr<int>(q);
            Console.WriteLine($"Массив 2: {w.ToString()}");
            Console.Write($"Массив 1 и 2 равны?");
            if (z == w)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            z++;
            Console.WriteLine($"Массив 1: {z.ToString()}");
            w--;
            Console.WriteLine($"Массив 2: {w.ToString()}");
            Console.ReadKey();
        }
    }
}
