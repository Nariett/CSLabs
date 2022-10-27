using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex t = new Regex(@"\+375\((29|44|25)\)\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}");//Запишите регулярное выражение для номера телефона любого мобильного оператора РБ
            string tel = "+375(29)-684-42-58, 3431, +375(44)-684-42-58"; 

            Match tels = t.Match(tel);
            while (tels.Success)
            {
                Console.WriteLine(tels);
                tels = tels.NextMatch();
            }
            Console.WriteLine("Все подходят для номера {0}", t);
            Regex n = new Regex(@"[0-9]{4}\ [A-Z]{2}\-7");//запишите регулярное выражение для регистрационного номера автомобиля в  г.Минске(7 регион)
            string num = "4536 AR-7, 0000 RT-6";
            Match q = n.Match(num);
            while (q.Success)
            {
                Console.WriteLine(q);
                q = q.NextMatch();
            }
            Console.WriteLine("Все подходят для номера {0}", num);
            Regex d = new Regex(@"[0-9]{2}.[0-9]{2}.([0-9]{2}|[0-9]{4})"); //дате в формате дд.мм.гг или дд.мм.гггг
            string data = "19.06.2022, 1414.87.20, 13.34.22";
            Match ds = d.Match(data);
            while (ds.Success)
            {
                Console.WriteLine(ds);
                ds = ds.NextMatch();
            }
            Console.WriteLine("Все подходят для номера {0}", d);
            Regex tm = new Regex(@"[0-9]{2}(.|:)[0-9]{2}");//времени в формате чч.мм или чч:мм
            string time = "22.10, 10:33";
            Match w = tm.Match(time);
            while (w.Success)
            {
                Console.WriteLine(w);
                w = w.NextMatch();
            }
            Console.WriteLine("Все подходят для номера {0}", tm);
           /* Regex rr = new Regex(@"[0-9]{2}(.|:)[0-9]{2}");//целое число без знака 
            string tt = "22.10, 10:33";
            Match a = rr.Match(tt);
            while (a.Success)
            {
                Console.WriteLine(a);
                a = a.NextMatch();
            }
            Console.WriteLine("Все подходят для номера {0}", rr);*/
            Console.ReadKey();
        }
    }
}
