using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] mas = { -5, -4, -4, -6, 2, 3, -7, 0, 8, 9 };
            int[] cor = new int [10];
            int min = mas[0];
            for(int i = 0; i<mas.Length;i++)
            {
                cor[i] = Math.Abs(mas[i]);
            }
            for (int i = 0;i < cor.Length-1;i++)
            {
                for (int j = i+1; j < cor.Length; j++)
                {
                    if (cor[i] > cor[j])
                    {
                        temp = cor[i];
                        cor[i] = cor[j];
                        cor[j] = temp;
                    }
                }
            }
            for (int i = 0; i < cor.Length; i++)
            {
                Console.Write(cor[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
