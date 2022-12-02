using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Part1._1
{
    internal class point
    {
        private int a;
        private int b;
        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public point(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            return $"Информаци о точке x = {this.a} y = {this.b}";
        }
    }
    class square : point
    {
        private int c;//x2
        private int d;//y2
        public int C { get { return c; } set { c = value; } }
        public int D { get { return d; } set { d = value; } }
        public square(int a,int b, int c, int d) : base(a,b)
        {
            this.c = c;
            this.d = d;
        }
        public override string ToString()//|AB|² = (y2 - y1)² + (x2 - x1)²
        {
            return $"Информаци о точке x = {this.A} y = {this.B}\nx1 = {this.c} y1 = {this.d}\nРазмер x сторон = {Math.Sqrt(Math.Abs(Math.Pow(d - this.A,2)-Math.Pow(c - this.B,2)))}";
        }
    }
    class pyramid : point
    {
        private int c;//x2
        private int d;//y2
        private int i;//x3
        private int h;//x3
        public int C { get { return c; } set { c = value; } }
        public int D { get { return d; } set { d = value; } }
        public int I { get { return i; } set { i = value; } }
        public int H { get { return h; } set { h = value; } }
        public pyramid(int a, int b, int c, int d, int i, int h) : base(a, b)
        {
            this.c = c;
            this.d = d;
            this.i = i;
            this.h = h;
        }
        public override string ToString()//|AB|² = (y2 - y1)² + (x2 - x1)²
        {
            return $"Информаци о точке x = {this.A} y = {this.B}\nx1 = {this.c} y1 = {this.d}\nРазмер x стороны = {Math.Sqrt(Math.Abs(Math.Pow(d - this.A, 2) - Math.Pow(c - this.B, 2)))}\nРазмер стороны y стороны = {Math.Sqrt(Math.Abs(Math.Pow(h - this.A, 2) - Math.Pow(i - this.B, 2)))}";
        }
    }
}
