using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcMethod cm = Calculator.Sum;
            CalcMethod cm2 = Calculator.Mult;
            CalcMethod cm3 = Calculator.Del;
            CalcMethod cm4 = Calculator.Sub;
            int result = 0; int result1 = 0; int result2 = 0; int result3 = 0;
            cm(2, 2, ref result);
            cm2(3, 3, ref result1);
            cm3(4, 2, ref result2);
            cm4(4, 2, ref result3);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadKey();
        }
    }
}
