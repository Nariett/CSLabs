using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = { { 1, 2, 3 },
                            {4, 5, 6 },
                            {7, 8, 9 } };
            for(int i = 0;i<mas.GetLength(0);i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j]+ " ");
                }
                Console.Write("\n");
            }
            int counter = 0;
            double rez = 0;
            Console.WriteLine("Below is the result");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        Console.WriteLine(mas[i, j]);
                        rez += mas[i, j];
                        counter++;
                    }
                }
            }
            Console.WriteLine(rez / (double)counter);
            Console.ReadKey();
        }
    }
}
