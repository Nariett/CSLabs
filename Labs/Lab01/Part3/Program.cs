using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed in m/s");
            int speedms = Convert.ToInt32(Console.ReadLine());
            int speedks = speedms / 1000;
            Console.WriteLine("Speed " + speedks + " k/h");
        }
    }
}
