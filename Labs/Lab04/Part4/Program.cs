using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = { { 1, 10, 3 },
                            {4, 5, 6 },
                            {7, 8, 9 }};
            int []max = new int[3];
            for(int i = 0; i < mas.GetLength(1);i++)
            {
                for(int j = 0; j < mas.GetLength(0);j++)
                {
                    int min = mas[0, i];
                    if (mas[j,i] > min | mas[j,i] == min)
                    {
                        max[i] = mas[j, i];
                    }
                }

            }
            for(int i = 0;i < max.GetLength(0);i++)
            {
                Console.Write(max[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
