using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Пароход");
            steamer Anna = new steamer("Anna", 152.2);
            Console.WriteLine(Anna.ToString());
            Anna.Type();
            Anna.swim();
            Console.WriteLine("Парусник");
            sailboat An = new sailboat("An", 200, 200);
            Console.WriteLine(An.ToString());
            An.Type();
            An.swim();
            Console.WriteLine("Корвет");
            corvette G = new corvette("Grugori", 200);
            Console.WriteLine(G.ToString());
            G.Type();
            G.swim();
            G.Show();
            Console.ReadKey();
        }
    }
}
