using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoArray a = new DemoArray(5, -10, "десять");
            a.Print();
            Console.WriteLine("все элементы массива преобразуются в положительные");
            a=+a;
            a.Print();
            Console.WriteLine("все элементы массива уменьшаются на единицу");
            a = -a;
            a.Print();
            Console.WriteLine("из всех элементов массива вычитается заданное число");
            a = a - 1;
            a.Print();
            DemoArray b = new DemoArray(5, 8, "пять");
            b.Print();
            if (a & b)
            {
                Console.WriteLine("схожи");
            }
            else
            {
                Console.WriteLine("разные");
            }
            Console.ReadKey();
        }
    }
}
