using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the dimension of the array a*b*c\nEnter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Enter c");
            c = Convert.ToInt32(Console.ReadLine());
            int[,,] mas = new int[a,b,c];
            for (int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    for(int k = 0; k < c; k ++)
                    {
                        Console.WriteLine($"Enter value mas {i} {j} {k}");
                        mas[i,j,k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            int p = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        if (mas[i,j,k] < 0)
                        {
                            p++;
                        }
                    }
                    if (p == 0)
                    {
                        Console.WriteLine($"Positive row {i} {j}");
                    }
                    else
                    {
                        p = 0;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
