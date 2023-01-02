using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 3;
            int[,] matrix = new int[n, n] { { 1, 7, 2 },
                                            { 2, 5, 1 },
                                            { 3, 6, 1 } };

            int count;
            bool flag;
            count = 0;
            try
            {
                for (int j = 0; j < n+1 ; j++)//тут ошибка n + 1
                {
                    flag = true;
                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int k = i + 1; k < n; k++)
                        {
                            if (matrix[i, j] == matrix[k, j])
                            {
                                flag = false;
                            }
                        }
                    }
                    if (flag)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Сработало исключение");
            }
        }
    }
}
