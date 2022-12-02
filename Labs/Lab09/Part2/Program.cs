using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    struct Data2
    {
        private DateTime data1;
        public Data2()
        {
            Console.WriteLine("Введите часы");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            int second = Convert.ToInt32(Console.ReadLine());
            this.data1 = new DateTime(2022, 11, 20, hour, minute, second);
        }
        public override string ToString()
        {
            return $"Часы:{data1.Hour} Минуты:{data1.Minute} Часы:{data1.Second}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во сотрудников");
            int size = Convert.ToInt32(Console.ReadLine());
            Data2[] company = new Data2[size];
            int c = 0;
            for (int i = 0; i < size; i++)
            {
                c++;
                Console.WriteLine($"Введите работника {c}: ");
                company[i] = new Data2();
            }
            c = 0;
            for(int i = 0; i < size; i++)
            {
                c++;
                Console.WriteLine($"Работник {c} : {company[i].ToString()}");
            }
            Console.ReadKey();
        }

    }
}
