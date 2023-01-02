using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        delegate int[] Mas(int[] mas);
        static int[] Inc(int[] mas)
        {
            for (int i = 1; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - i; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        int temp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp;
                    }
                }
            }
            return mas;
        }
        static int[] DInc(int[] mas)
        {
            for (int i = 1; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - i; j++)
                {
                    if (mas[j] < mas[j + 1])
                    {
                        int temp = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        static void PrintArray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] Rand(int x)
        {
            Random rand = new Random();
            int[] mas = new int[10];
            int q = 0;
            if (x == 1)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    do
                    {
                        q = rand.Next(0, 100);
                    }
                    while (q % 2 == 0);
                    mas[i] = q;
                }
            }
            else
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    do
                    {
                        q = rand.Next(0, 100);
                    }
                    while (q % 2 != 0);
                    mas[i] = q;
                }
            }
            return mas;
        }
        static void Main(string[] args)
        {
            int[] x = Rand(1);
            int[] y = Rand(2);
            Mas q = new Mas(Inc);
            Mas w = new Mas(DInc);
            Console.WriteLine("Массив 1");
            PrintArray(x);
            Console.WriteLine("Массив 2");
            PrintArray(y);
            Console.WriteLine("Массив 1 Сорт");
            q(x);
            PrintArray(x);
            w(x);
            PrintArray(x);
            Console.WriteLine("Массив 2 Сорт");
            q(y);
            PrintArray(y);
            w(y);
            PrintArray(y);
            Console.ReadKey();
        }
    }
}

