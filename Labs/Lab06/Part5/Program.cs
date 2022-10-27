using System;

namespace Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[][] MyArray;
                Console.Write(" введите количество строк: ");
                string line = Console.ReadLine();
                int n = int.Parse(line.Trim());
                MyArray = new int[n][];
                for (int i = 0; i < MyArray.Length; i++)
                {
                    line = Console.ReadLine();
                    line = line.Trim();
                    n = line.IndexOf(" ");
                    while (n > 0)
                    {
                        line = line.Remove(n, 1);
                        n = line.IndexOf(" ");
                    }
                    string[] mas = line.Split(' ');
                    MyArray[i] = new int[mas.Length];
                    for (int j = 0; j < MyArray[i].Length; j++)
                    {
                        MyArray[i][j] = int.Parse(mas[i]);
                    }
                }
                PrintArray("Исходный массив", MyArray);
                for (int i = 0; i < MyArray.Length; i++) Array.Sort(MyArray[i]);
                PrintArray("итоговый массив", MyArray);
            }
            catch(Exception e)
            {

                Console.WriteLine(" Вознико исключение" + e.Message);
            }
        Console.ReadKey();
        }
        static void PrintArray(string a, int[][] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.Length; i++)
{
                foreach (int x in mas[i]) Console.Write("{0}", x);
                Console.WriteLine();
            }
        }

    }

}
