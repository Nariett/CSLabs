using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] a = { 'm', 'a', 'X', 'i', 'M', 'u', 'S', '!', '!', '!' };
            char[] b = "кол около колокола".ToCharArray();
            PrintArray("Исходный массив a: ", a);
            for (int x = 0; x < a.Length; x++)
                if (char.IsLower(a[x])) a[x] = char.ToUpper(a[x]);
            PrintArray("Изменный массив а:", a);
            Counter("Кол-во знаков ", a);
            PrintArray("Изменный массив b:", b);
            Array.Reverse(b);
            PrintArray("Изменный массив b:", b);
            Console.ReadKey();
        }
        static void PrintArray(string line, Array a)
        {
            Console.WriteLine(line);
            foreach (object x in a) Console.Write(x);
            Console.WriteLine('\n');
        }
        static void Counter(string line,Array a)
        {
            int counter = 0;
            Console.WriteLine(line);
            foreach (object x in a) if(x.ToString() == "!")counter++;
            Console.Write(counter);
            Console.WriteLine('\n');
        }
    }
}
