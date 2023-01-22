using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string employees = "abc#d##c";
            Stack<char> text = new Stack<char>();
            foreach (var c in employees)
            {
                if ( c == '#')
                {
                    if (text.Count > 0)
                    {
                        text.Pop();
                    }
                }
                else
                {
                    text.Push(c);
                }
            }
            foreach (var person in text) Console.Write(person);
            Console.ReadKey();

        }
    }
}
