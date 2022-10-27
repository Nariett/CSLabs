using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Part9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввдите время");
            string time = Console.ReadLine();
            char[] div = { ':' };
            string[] hm = time.Split(div);
            int hour = Convert.ToInt32(hm[0]);
            int minute = Convert.ToInt32(hm[1]);
            if(hour > 23 && minute >59)
            {
                Console.WriteLine("Введено неправльное время");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("Введите кол-во минут на которое хотите увеличить время");
            int n = Convert.ToInt32(Console.ReadLine());
            minute += n;
            if(minute >59)
            {
                hour += 1;
                minute = minute % 60;
            }
            if(hour > 23)
            {
                hour = hour % 24;
            }
            time = hour + ":" + minute;
            Console.WriteLine(time);
            Console.ReadKey();
        }
    }
}
