using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n]; 
            for(int i = 0; i < mas.Length;i++)
            {
                Console.WriteLine($"Enter cell value {i}");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int fp = 0;
            int lp = 0;
            int sum = 0;
            bool f = false;
            for(int i = 0; i < mas.Length;i++)
            {
                if(f == false)
                {
                    if (mas[i] > 0)
                    {
                        fp = i;
                        f = true;
                    }
                }
                if (mas[i] > 0)
                {
                    lp = i;
                }
            }
            for(int i = fp;i<lp+1;i++)
            {
                Console.Write(mas[i] + " ");
                sum += mas[i];
            }
            Console.WriteLine("\nAnswer is " + sum);
            Console.ReadKey();
        }
    }
}
