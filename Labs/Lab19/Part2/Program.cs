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
            Queue<string> people = new Queue<string>();
            using (StreamReader read = new StreamReader("people.txt"))
            {
                while (!read.EndOfStream)
                {
                    people.Enqueue(read.ReadLine());
                }
            }
            Console.WriteLine("Сдали сессию: ");
            foreach (var person in people)
            {
                string[] mark = person.Split(' ');
                if (Convert.ToInt32(mark[3]) > 3 && Convert.ToInt32(mark[4]) > 3 && Convert.ToInt32(mark[5]) > 3)
                {
                    Console.WriteLine(person);
                }
            }
            Console.WriteLine("Не сдали сессию: ");
            foreach (var person in people)
            {
                string[] mark = person.Split(' ');
                if (Convert.ToInt32(mark[3]) < 3 || Convert.ToInt32(mark[4]) < 3 || Convert.ToInt32(mark[5]) < 3)
                {
                    Console.WriteLine(person);
                }
            }
            Console.ReadKey();
        }
    }
}
