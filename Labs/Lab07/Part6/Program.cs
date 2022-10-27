using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex t = new Regex(@"[0,1,2][0-9].[0-6][0-9].[0-6][0-9]");
            string tel = "19.59.61 , 12.87.20, 22.52.22";
            Match tels = t.Match(tel);
            while (tels.Success)
            {
                string[] x = tels.Value.Split('.');
                int hh = Convert.ToInt32(x[0]);
                int mm = Convert.ToInt32(x[1]);
                int ss = Convert.ToInt32(x[2]);
                if (ss>=60)
                {
                    mm++;
                    ss = 0;
                }
                if(mm >=60 )
                {
                    hh++;
                    mm = 0;
                }
                Console.WriteLine(hh + "." + mm);
                tels = tels.NextMatch();
            }
            Console.ReadKey();
        }
    }
}
