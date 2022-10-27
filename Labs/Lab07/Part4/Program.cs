using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = @"Контакты в Москве tel:123-45-67, 123-34-56; fax:123-56-45. 
                      Контакты в Саратове tel:12-34-56; fax:11-56-45";
            Console.WriteLine("Старые данные\n" + text);
            string newText = Regex.Replace(text, "123-", "890-");
            Console.WriteLine("Новые данные\n" + newText);
            Console.ReadKey();
        }
    }
}
