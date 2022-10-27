using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"[0-9]{2}.[0-9]{2}.[0-9]{2}");
            string text1 = "tel:123-45-67";
            string text2 = "tel:no";
            string text3 = "tel:12-34-56";
            Console.WriteLine(r.IsMatch(text1));
            Console.WriteLine(r.IsMatch(text2));
            Console.WriteLine(r.IsMatch(text3));
            Console.ReadKey();
        }
    }
}
