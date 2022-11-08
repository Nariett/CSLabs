using System;

namespace Part1
{
    internal class segment
    {
        int x1, x2, y1, y2;
        public int X1//свойсвто 
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int Y2
        {
            get { return y1; }
            set { y1 = value; }
        }
        public segment()//конструктор
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
        public segment(int x1, int x2, int y1, int y2)//конструктор
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public void Enter(int x1, int x2)
        {
            this.x1 = x1;
            this.x2 = x2;
        }
        public void Print()
        {
            Console.WriteLine($"Координаты\nx1 = {x1}\nx2 = {x2}\ny1 = {y1}\ny2 = {y2}");
        }
        public int Length()
        {
            return Convert.ToInt32(Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2)));
        }
        ~segment()
        {
            Console.WriteLine("Cработал деструктор для объекта");
            Console.ReadKey();
        }

    }
}
