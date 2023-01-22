using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            using (StreamReader read = new StreamReader("people.txt"))
            {
                while (!read.EndOfStream)
                {
                    People person = new People(read.ReadLine());
                    if(person.Double() == true)
                    {
                        using (StreamWriter write = new StreamWriter("double.txt"))
                        {
                            write.WriteLine(person);
                        }
                    }
                    list.Add(person);
                }
            }
            foreach (var q in list)
            {
                Console.WriteLine(q.ToString());
            }
            Console.ReadKey();

        }
    }
}
