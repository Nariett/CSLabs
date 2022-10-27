using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Part11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введенное время");
            char[] time = { '1', '2', ':', '4','5'};
            Console.WriteLine(time);
            int hour = Convert.ToInt32(Convert.ToString(time[0])+ Convert.ToString(time[1]));
            int minute = Convert.ToInt32(Convert.ToString(time[3]) + Convert.ToString(time[4]));
            if (hour > 23 && minute > 59)
            {
                Console.WriteLine("Введено неправльное время");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("Введите кол-во минут на которое хотите увеличить время");
            int n = Convert.ToInt32(Console.ReadLine());
            minute += n;
            if (minute > 59)
            {
                hour += 1;
                minute = minute % 60;
            }
            if (hour > 23)
            {
                hour = hour % 24;
            }
            Console.WriteLine(hour + ":" + minute);
            Console.ReadKey();
        }

    }
}
