using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            segment AB = new segment();
            AB.Enter();
            AB.Print();
            int length = AB.Length();
            Console.WriteLine($"Длина равна {length}");
            Console.ReadKey();
        }
    } 
}
