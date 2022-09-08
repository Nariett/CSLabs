using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, lenght, sqare;
            Console.WriteLine("Enter the hight of the  trapezoid");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the middle line of the trapezoid");
            lenght = Convert.ToDouble(Console.ReadLine());
            sqare = lenght * height;
            Console.WriteLine("The area is equal to " + sqare);
        }
    }
}
