using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    struct Complex
    {
        public double a;//действительная часть 
        public double b;//мнимая часть
        public Complex(double ax, double bx)
        {
            this.a = ax;
            this.b = bx;
        }
        public void Print()
        {
            Console.WriteLine($"Комплексное число: {this.a}+{this.b}i");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительную часть");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть");
            double b = Convert.ToDouble(Console.ReadLine());
            Complex ax = new Complex(a, b);
            ax.Print();
            Console.WriteLine("Введите действительную часть");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть");
            b = Convert.ToDouble(Console.ReadLine());
            Complex bx = new Complex(a, b);
            bx.Print();
            Complex q;
            Console.WriteLine("Сложение комплесных чисел");
            q.a = ax.a + bx.a;
            q.b = ax.b + bx.b;
            q.Print();
            Console.WriteLine("Умножение комплексных чисел");
            q.a = ax.a * bx.a;
            q.b = ax.b * bx.b;
            q.Print();

            Console.ReadKey();
        }
    }
}
