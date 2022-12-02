using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cowA = new Cow("CowA", 12);
            Cow cow = new Cow("Cow", 5);
            Console.WriteLine("--------EAT----------");
            cow.Eat();
            cowA.Eat();
            (cowA as Cow).Eat();
            ((Cow)cowA).Eat();
            ((IVoice)cow).Voice();
            Console.WriteLine("");
            cowA.Voice();//вызывается метод из класса Animal 
            (cowA as Cow).Voice();//вызывается метод для класса cow как экземпляр класса Anial(CowA) 
            //конвертируется в Cow
            ((IVoice)cowA).Voice();//вызывается метод из класса cow.
            Console.WriteLine("");
            List  <BaseAnimal> bs = new List <BaseAnimal>();
            bs.Add(cow);
            bs.Add(cowA);
            bs.Add(new Animal());
            foreach (var item in bs)
            {
                item.DoSomeThing(); //для всех
                if (item is Animal) (item as Animal).Eat(); //только для тех у кого реализован метод Eat
                if (item is Cow) (item as Cow).Eat();
            }
            Console.ReadKey();
        }
    }
}
