using Circlee;
using System;

namespace Lab16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a = 0, SinA = 0;
            try
            {

                Console.WriteLine("Введите сторону A");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите синус стороны A");
                SinA = Convert.ToDouble(Console.ReadLine());
                Circle x = new Circle();
                x.X = a;
                x.Sin = SinA;
                Console.WriteLine($"Радиус равен = {x.Rad()}");
                Console.WriteLine($"Коcинусы = {x.Cos()}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
