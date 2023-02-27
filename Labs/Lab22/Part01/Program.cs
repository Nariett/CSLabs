using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread one = new Thread(ReadTextOne);
            Thread two = new Thread(ReadTextTwo);
            one.Start();
            two.Start();
            Console.ReadKey();
        }
        static void ReadTextOne()
        {
            string textOne;
            int sum = 0;
            using (StreamReader read = new StreamReader("C:\\Users\\samsi\\OneDrive\\Рабочий стол\\textOne.txt"))
            {
                textOne = read.ReadToEnd();
                Console.WriteLine($"Текст из файла textOne: {textOne}");
            }
            for (int i = 0; i < textOne.Length; i++)
            {
                sum += Convert.ToInt32(textOne[i]);
            }
            Console.WriteLine($"Сумма из файла 1 :{sum}");
        }
        static void ReadTextTwo()
        {
            string textTwo;
            int sum = 0;
            using (StreamReader read = new StreamReader("C:\\Users\\samsi\\OneDrive\\Рабочий стол\\textTwo.txt"))
            {
                textTwo = read.ReadToEnd();
                Console.WriteLine($"Текст из файла textTwo: {textTwo}");
            }
            for (int i = 0; i < textTwo.Length; i++)
            {
                sum += Convert.ToInt32(textTwo[i]);
            }
            Console.WriteLine($"Сумма из файла 2 :{sum}");
        }
    }
}
