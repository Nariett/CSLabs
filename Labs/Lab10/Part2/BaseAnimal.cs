using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal abstract class BaseAnimal
    {
        abstract public void DoSomeThing();
    }
    interface IVoice
    {
        void Voice();
    }
    class Animal : BaseAnimal, IVoice
    {
        protected string _name;
        public Animal() : this("Noname") { }
        public Animal(string name)
        {
            _name = name;
        }
        public override void DoSomeThing()
        {
            Console.WriteLine($"{GetType().Name} {_name} ест");
        }
        public void Eat()
        {
            Console.WriteLine($"{GetType().Name} {_name} ест ");
        }
        public virtual void Sleep()
        {
            Console.WriteLine($"{GetType().Name}{_name} спит ");
        }
        public void Voice()
        {
            Console.WriteLine($"{GetType().Name} {_name} имеет голос");
        }
    }
    class Cow : Animal, IVoice
    {
        int _milk;
        public Cow() : base()
        {
            _milk = 10;
        }
        public Cow(string name, int milk) : base(name)
        {
            _milk = milk;
        }
        public new void Eat() //Обычный метод ЕСТ -НОВАЯ РЕАЛИЗАЦИЯ
        {
            Console.WriteLine($"{ GetType().Name} { _name} ест траву и сено");
        }
        public override void Sleep() ///Переопределение виртуального метода СПИТ
        {
            Console.WriteLine($"{ GetType().Name} { _name} спит стоя");
        }
        //сокрытие базовой реализации
        public new void Voice() //Обычный метод ГОЛОС -НОВАЯ РЕАЛИЗАЦИЯ
        {
            Console.WriteLine($"{ GetType().Name} { _name} мычит");
        }
        void IVoice.Voice() // ЯВНАЯ!! РЕАЛИЗАЦИЯ МЕТОДА ГОЛОС У ИНТЕРФЕЙСА!
        {
            Console.WriteLine($"{ GetType().Name} { _name}: МУ - МУ ");
        }
    }
}
