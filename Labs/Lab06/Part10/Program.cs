using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввдите время");
            StringBuilder time = new StringBuilder(Console.ReadLine());
            string hour = "";
            string minut = "";
            int index = 0;
            for (int i = 0;i < time.Length;i++)
            {
                if (time[i] != ':')
                {
                    hour += time[i];
                }
                else
                {
                    index = i;
                    break;
                }
            }
            for (int i = index+1; i < time.Length; i++)
            {
                minut+=time[i];
            }
            int h = Convert.ToInt32(hour);
            int m = Convert.ToInt32(minut);
            if (h > 23 && m > 59)
            {
                Console.WriteLine("Введено неправльное время");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("Введите кол-во минут на которое хотите увеличить время");
            int n = Convert.ToInt32(Console.ReadLine());
            m += n;
            if (m > 59)
            {
                h += 1;
                m = m % 60;
            }
            if (h > 23)
            {
                h = h % 24;
            }
            time = new StringBuilder(h + ":" + m);
            Console.WriteLine(time);
            Console.ReadKey();
        }
    }
}
