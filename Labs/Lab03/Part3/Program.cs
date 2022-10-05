using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 24;
            for(int i = 1864; i <=2022 ; i++)
            {
                price = price + (price * 0.06);
            }
            Console.WriteLine($"The result is  {price}");
            Console.ReadKey();
        }
    }
}
