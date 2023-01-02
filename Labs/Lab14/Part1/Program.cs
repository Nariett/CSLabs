using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "Эдуард", "Шумахеров","Олегович" };
            Person man = new Person(text);
            NameShow x = new NameShow(man.FullName);
            Console.WriteLine($"Полное имя {x()}");
            NameShow y = new NameShow(man.ShortName);
            Console.WriteLine($"Короткое {y()}");
            Console.ReadKey();
        }
    }
}
