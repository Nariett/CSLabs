using System;
using System.Linq;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 1;
            Console.WriteLine("Введите размерность массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[size];
            Random x = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = x.NextDouble() * 10 - 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            var arrReverse = arr.Reverse();
            Console.WriteLine();
            var negative = from n in arr
                           where n < 0
                           select n;
            foreach (double p in negative)
            {
                sum = sum * p;
                Console.Write(p + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Произведение отрицательных " + sum);
            foreach (double p in arrReverse)
            {
                Console.Write(p + " ");
            }
            Console.ReadLine();
        }
    }
}
