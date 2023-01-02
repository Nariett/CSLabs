using System;
using System.IO;

namespace Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("D:\\temp");
            Directory.CreateDirectory("D:\\temp\\K1");
            Directory.CreateDirectory("D:\\temp\\K1");
            Directory.CreateDirectory("D:\\temp\\K2");
            File.Create("D:\\temp\\K1\\t1.txt").Close();
            using (StreamWriter write = new StreamWriter("D:\\temp\\K1\\t1.txt"))
            {
                write.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г.Саратов");
            }
            File.Create("D:\\temp\\K1\\t2.txt").Close();
            using (StreamWriter write2 = new StreamWriter("D:\\temp\\K1\\t2.txt"))
            {
                write2.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            }
            FileInfo("D:\\temp\\K1\\t1.txt");
            FileInfo("D:\\temp\\K1\\t2.txt");
            File.Create("D:\\temp\\K2\\t3.txt").Close();
            using (StreamWriter write3 = new StreamWriter("D:\\temp\\K2\\t3.txt"))
            {
                using (StreamReader read1 = new StreamReader("D:\\temp\\K1\\t1.txt"))
                {
                    string text1 = read1.ReadToEnd(); 
                    write3.WriteLine(text1);
                }
                using (StreamReader read2 = new StreamReader("D:\\temp\\K1\\t2.txt"))
                {
                    string text2 = read2.ReadToEnd();
                    write3.WriteLine(text2);
                }
            }
            FileInfo("D:\\temp\\K2\\t3.txt");
            File.Copy("D:\\temp\\K1\\t2.txt","D:\\temp\\K2\\t2.txt");
            File.Delete("D:\\temp\\K1\\t2.txt");
            File.Copy("D:\\temp\\K1\\t1.txt", "D:\\temp\\K2\\t1.txt");
            Directory.Move("D:\\temp\\K2", "D:\\temp\\ALL");
            File.Delete("D:\\temp\\K1\\t1.txt");
            Directory.Delete("D:\\temp\\K1");
            Console.WriteLine("Программы выполнена");
            Console.ReadKey();
        }
        public static void FileInfo(string path)
        {
            FileInfo info1 = new FileInfo(path);
            Console.WriteLine($"Информация о файле {info1.Name}" +
                              $"\nИмя файла: {info1.Name}" +
                              $"\nПуть к файлу: {info1}" +
                              $"\nДата создания: {info1.CreationTime}" +
                              $"\nРазмер файла: {info1.Length}" +
                              $"\nФайл только для чтения: {info1.IsReadOnly}");
        }
    }
}
