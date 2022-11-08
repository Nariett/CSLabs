using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Threading;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            segment AB = new segment();
            AB.Print();
            int length = AB.Length();
            Console.WriteLine($"Длина равна {length}");
            Console.WriteLine("Введите x1");
            try
            {
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите x2");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите y1");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите y2");
                int y2 = Convert.ToInt32(Console.ReadLine());
                if (x1 < 0 || x2 < 0 || y1 < 0 || y2 < 0)
                {
                    throw new Exception("число меньше нуля");
                }
                else
                {
                    segment AT = new segment(x1,x2,y1,y2);
                    AT.Print();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
