using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance between the points");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the distance by how much more the car passes");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time for how late the cyclist arrived");
            double t = Convert.ToDouble(Console.ReadLine());
            double dis = -(((t * s1) - (s * s1)) / t);
            Console.WriteLine(dis);
        }
    }
}
