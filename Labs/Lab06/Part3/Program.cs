using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string poesms = "тучки небесные вечные странники";
            char[] div = {' '};
            string[] parts = poesms.Split(div);
            Console.WriteLine("Результат разбиеныя строки на части: ");
            for (int i = parts.Length-1; i >= 0; i--)
            {
                Console.WriteLine(parts[i]);
            }
            string whole = String.Join("|", parts);
            Console.WriteLine("Результат сборки: ");
            Console.WriteLine(whole);
            Console.ReadKey();
        }
    }
}
