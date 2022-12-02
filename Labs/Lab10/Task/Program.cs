﻿using System;
using System.Data.SqlTypes;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDemo[] a = new IDemo[4];
            //заполнение массива
            a[0] = new DemoPoint(0, 1);
            a[1] = new DemoPoint(-3, 0);
            a[2] = new DemoShape(3, 4, 0);
            a[3] = new DemoShape(0, 5, 6);
            //просмотр массива
            foreach (IDemo x in a)
            {
                x.Show();
                Console.WriteLine("Dlina={0:f2}",x.Dlina());
                Console.WriteLine("x = " + x.X);
                Console.WriteLine("y = " + x.Y);
                Console.WriteLine("z = " + x.Z);
                x[1] += x[0];
                Console.Write("новые координаты -");
                x.Show();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        interface IDemo
        {
            void Show();
            double Dlina();
            int X { get; }
            int Y { get; }
            int Z { get; }
            int this[int i] { get; set; }
        }
        class DemoPoint : IDemo
        {
            protected int x;
            protected int y;
            public DemoPoint(int x, int y)
            {
                this.x = x; this.y = y;

            }
            public void Show()
            {
                Console.WriteLine("точка на плоскости: ({0}, {1})", x, y);
            }
            public double Dlina() 
            {
                return Math.Sqrt(x * x + y * y);
            }
            public int X 
            {
                get
                {
                    return x;
                }
            }
            public int Y 
            {
                get
                {
                    return y;
                }
            }
            public int Z
            {
                get
                {
                    return 0;
                }
            }

            public int this[int i]
            {
                get
                {
                    if (i == 0) return x;
                    else if (i == 1) return y;
                    else throw new Exception("недопустимое значение индекса");
                }
                set
                {
                    if (i == 0) x = value;
                    else if (i == 1) y = value;
                    else throw new Exception("недопустимое значение индекса ");
                }
            }
        }
        class DemoShape : DemoPoint, IDemo
        {
            protected int z;
            public DemoShape(int x, int y, int z) : base(x, y)
            {
                this.z = z;
            }
            public new void Show()
            {
                Console.WriteLine("точка в пространстве: ({0}, {1}, {2})", x, y, z);
            }
            public int Y
            {
                get
                {
                    return y;
                }
            }
            public int Z///
            {
                get
                {
                    return z;
                }
            }

            public new double Dlina()
            {
                return Math.Sqrt(x * x + y * y + z * z);
            }
            public new int this[int i]
            {
                get
                {
                    if (i == 0) return x;
                    else if (i == 1) return y;
                    else if (i == 2) return z;
                    else throw new Exception("недопустимое значение индекса ");

                }
                set
                {
                    if (i == 0) x = value;
                    else if (i == 1) y = value;
                    else if (i == 2) z = value;
                    else throw new Exception("недопустимое значение индекса ");
                }
            }
        }
    }
}
