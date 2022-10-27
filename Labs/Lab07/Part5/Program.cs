using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex t = new Regex(@"[0-3][0-9].[0-1][0-9].[1,2][9,0][0-9][0-9]");
            string tel = "19.01.2022, 1414.87.20, 13.34.22";

            Match tels = t.Match(tel);
            while (tels.Success)
            {
                Console.WriteLine(tels);
                tels = tels.NextMatch();
            }
            Console.ReadKey();
        }
    }
}
