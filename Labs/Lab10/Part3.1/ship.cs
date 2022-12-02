using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3._1
{
    internal abstract class ship
    {
        abstract public void swim();
    }
    interface Name
    {
        void Name();
    }
    interface ICloneable
    {
        void Show();
    }
    class steamer : ship, Name
    {
        private string name;
        private double power;
        public steamer(string name, double power)
        {
            this.name = name;
            this.power = power;
        }
        public override void swim()
        {
            Console.WriteLine($"{GetType().Name} плывет");
        }
        virtual public void Type()
        {
            Console.WriteLine($"Это пароход");
        }
        public override string ToString()
        {
            return $"Пароход {name} с мощностью {power}";
        }
        public void Name()
        {
            Console.WriteLine($"Тип судна {GetType().Name}");
        }
    }
    class sailboat : ship, Name
    {
        private string name;
        private double sizex;
        private double sizey;
        public sailboat(string name, double x, double y)
        {
            this.name = name;
            this.sizex = x;
            this.sizey = y;
        }
        public override void swim()
        {
            Console.WriteLine($"{GetType().Name} плывет");
        }
        virtual public void Type()
        {
            Console.WriteLine($"Это парусник");
        }
        public override string ToString()
        {
            return $"Парусник {name} с размером паруса {sizex} * {sizey}";
        }
        public void Name()
        {
            Console.WriteLine($"Тип судна {GetType().Name}");
        }
    }
    class corvette : ship,Name, ICloneable
    {
        private string name;
        private int gun;
        public corvette(string name, int gun)
        {
            this.name = name;
            this.gun = gun;
        }
        public override void swim()
        {
            Console.WriteLine($"{GetType().Name} плывет");
        }
        virtual public void Type()
        {
            Console.WriteLine($"Это корвет");
        }
        public override string ToString()
        {
            return $"Корвет {name} с {gun} пушками";
        }
        public void Name()
        {
            Console.WriteLine($"Тип судна {GetType().Name}");
        }
        public void Show()
        {
            Console.WriteLine("Корабль стоит больших денег");
        }
    }
}
