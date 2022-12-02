using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class rectangle:figura
    {
        private int ac;
        public int AC { get { return ac; } set { ac = value; } }
        public rectangle(int ac,int ab):base(ab)
        {
            this.ac = ac;
        }
        public int Perim()
        {
            return this.ac * this.A;
        }
        public override string ToString()
        {
            return $"Информация о прямоугольнике\nДлина a = {this.A}\nДлина b = {this.ac}";
        }
    }
}
