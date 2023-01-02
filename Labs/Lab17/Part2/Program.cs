using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader read = new StreamReader("D:\\C#\\Lab17\\TextFile2.txt"))
            {
                using (StreamWriter write = new StreamWriter("D:\\C#\\Lab17\\WriteFile.txt"))
                {
                    while (!read.EndOfStream)
                    {
                        string text = read.ReadLine();
                        
                        if (text.Length % 2 == 0)
                        {
                            Console.WriteLine(text);
                            write.WriteLine(text);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
