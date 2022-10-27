using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"[-+]?\d+");
            string text = @"5*10=50 -80/40=-2";
            int count = 0;
            Match teg = r.Match(text);
            int sum = 0;
            while (teg.Success)
            {
                Console.WriteLine(teg);
                sum += int.Parse(teg.ToString());
                teg = teg.NextMatch();
                count++;
            }
            Console.WriteLine("sum=" + sum);
            Console.WriteLine("счетчик=" + count);
            Console.ReadKey();

        }
    }
}
