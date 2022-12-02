using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class circle : figura
    {
        private int diametr;
        public int Diametr { get { return diametr; } set { diametr = value; } }

        public circle (int ab,int z): base(ab)
        {
            ab = 0;
            diametr = z;
        }
        public double Perim()
        {
            return diametr * Math.PI;
        }
        public override string ToString()
        {
            return $"Информация о круге\nДлина a = {this.A}\nДиаметр d = {this.Diametr}";
        }

    }
}
