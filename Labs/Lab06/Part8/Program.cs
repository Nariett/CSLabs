using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строки: ");
            string text = Console.ReadLine();
            //Console.WriteLine(text);
            Console.WriteLine("Потворяющиеся символы: ");
            for(int i = 0; i < text.Length;i++)
            {
                bool c = true;
                for(int j = 0; j < text.Length;j++)
                {
                    if (i == j) continue;
                    if (text[i] == text[j])
                    {
                        c = false;
                        break;
                    }
                }
                if (c == true)
                {
                    Console.WriteLine(text[i]);
                }
                
            }
            Console.ReadKey();
        }
    }
}
