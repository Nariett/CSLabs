using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface ICompareble
    {
        int CompareTo(object obj);
    }
    internal class DemoPoint : IComparable
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
            Console.WriteLine("Точка на плоскости: ({0}, {1})", x, y);
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
        public static bool operator ==(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) == 0);
        }
        public static bool operator !=(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) == 0);
        }
        public static bool operator >(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) == 1);
        }
        public static bool operator <(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) == -11);
        }
        public static bool operator >=(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) >= 0);
        }
        public static bool operator <=(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) <= 1);
        }
    }
}
