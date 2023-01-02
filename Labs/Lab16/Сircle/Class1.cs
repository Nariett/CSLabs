namespace Сircle
{
    public class Circle 
    {
        private double a;
        private int sinA;
        public Circle(double a, int sinA)
        {
            this.a = a;
            this.sinA = sinA;
        }
        public void Print()
        {
            Console.WriteLine($"{a}\n{sinA}");
        }

    }
}