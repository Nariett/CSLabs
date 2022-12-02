using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoPoint[] a = new DemoPoint[4];
            a[0] = new DemoPoint(5, -1);
            a[1] = new DemoPoint(-3, 3);
            a[2] = new DemoPoint(3, 4);
            a[3] = new DemoPoint(0, 1);
            Array.Sort(a);
            Console.WriteLine();
            foreach (DemoPoint x in a)
            {
                x.Show();
                Console.WriteLine("Dlina ={0:f2}",x.Dlina());
            }
            Console.ReadKey();
        }
    }
    interface IComparable
    {
        int CompareTo(object obj);
    }
    class DemoPoint : IComparable
    {
        protected int x;
        protected int y;
        public DemoPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Show()
        {
            Console.WriteLine("точка на плоскости: ({0}, {1})", x, y);
        }
        public double Dlina()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public int CompareTo(object obj)
        {
            DemoPoint b = (DemoPoint)obj;
            if (this.Dlina() == b.Dlina()) return 0;
            else if (this.Dlina() > b.Dlina()) return 1;
            else return -1;
        }
    }
}
