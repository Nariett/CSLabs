using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entry person = new Entry();
            person.print();
            Console.WriteLine("\n"+ person.Name);
            Console.WriteLine("работа с массивом данных");
            Console.WriteLine("введите размер размера записей");
            int zap = Convert.ToInt32(Console.ReadLine());
            book zp = new book(zap);
            Entry cur;
            for(int i = 0; i < zap;i++)
            {
                cur = new Entry();
                zp[i] = cur;
            }
            Console.WriteLine("Список всех записей:\n");
            for (int i = 0; i < zap; i++)
            {
                Console.WriteLine($"Информация о человеке {i + 1}");
                zp[i].print();
                Console.Write("\n");
            }
            Console.WriteLine("введите номер телефона");
            zp.searchNum(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("введите дату");
            int[] ke = new int[3];
            for(int j = 0; j < ke.Length; j++)
            {
                ke[j] = Convert.ToInt32(Console.ReadLine());
            }
            zp.searchData(ke);
            Console.ReadKey();
        }
    }
}
