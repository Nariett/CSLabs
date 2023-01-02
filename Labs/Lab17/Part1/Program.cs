using System;
using System.IO;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader read = new StreamReader("D:\\C#\\Lab17\\TextFile.txt"))
            {
                string text = read.ReadToEnd();
                Console.WriteLine($"Текст в текстовом файле: {text}\nСлова подходящие под условие:");
                string[] arr = text.Split(' ');
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i][0] == arr[i][arr[i].Length - 1])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
