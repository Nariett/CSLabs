using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Part1
{
    internal class figura
    {
        private int a;
        public int A { get { return a; } set { a = value; } }
        public figura(int a)
        {
            this.a = a;
        }
        public override string ToString()
        {
            return $"Информация о фигре\nДлина a = {this.a}";
        }
    }

}
