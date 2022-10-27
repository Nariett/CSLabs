using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку: ");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Исходная строка: " + a);
            for (int i = 0; i < a.Length;)
                if (char.IsPunctuation(a[i])) a.Remove(i, 1);
                else ++i;
            string str = a.ToString();
            string[] s = str.Split(' ');
            Console.WriteLine("Искомые слова: ");
            for (int i = 0; i < s.Length ; ++i)
                if (s[i][0] == s[i][s.Length]) Console.WriteLine(s[i]);
            Console.ReadKey();
        }
    }
}
