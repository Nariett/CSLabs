using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class trapezoid:figura
    {
        private int b;
        private int c;
        private int d;
        public int B { get { return b; } set { b = value; } }
        public int C { get { return c; } set { c = value; } }
        public int D { get { return d; } set { d = value; } }
        public trapezoid(int a,int b,int c,int d):base(a)
        {
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public int Perim()
        {
            return this.A + b + c + d;
        }
        public override string ToString()
        {
            return $"Информация о трапеции\nДлина a = {this.A}\nДлина b = {this.b}\nДлина c = {this.c}\nДлина d = {this.d}";
        }
    }
}
