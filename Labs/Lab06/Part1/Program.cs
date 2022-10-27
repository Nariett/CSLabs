using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] z = { 't', 'e', 's', 't'};
            string x = "test";
            string a = new string(z);
            string b = x;
            StringBuilder Builder = new StringBuilder("test");
            Console.WriteLine($"строка номер 1 {a}");
            Console.WriteLine($"строка номер 2 {b}");
            Console.WriteLine($"строка номер 3 {Builder}");
            Console.ReadKey();
        }
    }
}
