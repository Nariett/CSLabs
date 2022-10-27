using System;

namespace Part1
{
    internal class segment
    {
        int x1, x2, y1, y2;
        public void Enter()
        {
            Console.WriteLine("Введите x1");
            this.x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2");
            this.x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            this.y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            this.y2 = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Координаты\nx1 = {x1}\nx2 = {x2}\ny1 = {y1}\ny2 = {y2}");
        }
        public int Length()
        {
            return Convert.ToInt32(Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2)));
        }

    }
}
