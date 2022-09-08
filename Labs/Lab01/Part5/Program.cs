using System;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Enter A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C");
            C = Convert.ToInt32(Console.ReadLine());
            if (A <= B & B <= C)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
