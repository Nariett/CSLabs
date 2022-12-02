using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoPoint a = new DemoPoint(-3, 0);
            DemoPoint b = new DemoPoint(0, 3);
            if (a == b) Console.WriteLine("Равно удалены от начала координат");
            else Console.WriteLine("не равно удалены от начала координат");
            if (a > b) Console.WriteLine("a расположена дальше от начала координат чем b");
            else Console.WriteLine("b расположена дальше от начала координат чем a");
            if (a < b) Console.WriteLine("b расположена дальше от начала координат чем a");
            else Console.WriteLine("a расположена дальше от начала координат чем b");
            if (a >= b) Console.WriteLine("a расположена дальше от начала координат чем b или точки равно удалены от начала координат");
            else Console.WriteLine("b расположена дальше от начала координат чем a или точки равно удалены от начала координат");
            if (a >= b) Console.WriteLine("b расположена дальше от начала координат чем a или точки равно удалены от начала координат");
            else Console.WriteLine("a расположена дальше от начала координат чем b или точки равно удалены от начала координат");
            Console.ReadKey();
        }
    }
}
