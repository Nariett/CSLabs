using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string poems = "Тучки небесные, вечные странники...";
            char[] div = {' ',',','.'};
            string[] parts = poems.Split(div);
            Console.WriteLine("Результат разбиения строки на части:");
            for(int i = 0; i < parts.Length; i++)
                if(parts[i]!="")Console.WriteLine(parts[i]);
            string whole = String.Join("|", parts,0,3);
            string whol = String.Join("|", parts, 3, 2);
            Console.WriteLine("Результат сборки: ");
            Console.WriteLine(whole+whol);
            Console.ReadKey();
            //строки появились из-за знаков препинания, которые разделялись как подсрока
        }
    }
}
