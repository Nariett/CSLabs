using System;

namespace Circlee
{
    public class Circle
    {
        private double x;
        private double sinA;
        public Circle(double x, double sinX)
        {
            this.x = x;
            this.sinA = sinX;
        }
        public Circle()
        {
            this.x = 1;
            this.x = 1;
        }
        public double X
        {
            set
            {
                if(value < 0 || value.GetTypeCode() != TypeCode.Double)
                {
                    throw new Exception("Меньше нуля или введен неверный формат");
                }
                else
                {
                    this.x = value;
                }
            }
        }
        public double Sin
        {
            set
            {
                if (value > 1 || value < -1)
                {
                    throw new Exception("Выход за границы");
                }
                else
                {
                    this.sinA = value;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"a = {this.x}\nsinA = {sinA}");
        }
        public double Rad()
        {
            return x / 2 * sinA;
        }
        public double Cos()
        {
            return Math.Sqrt(1 - sinA);
        }
    }
}
