using System;

namespace Part2
{
    enum Category { Weather, News, SportNews, Humor, EventsNews }
    class Operator
    {
        private delegate void MethodAddTo(string msg);
        private event MethodAddTo SubscribeNews;
        private event MethodAddTo Weather;
        private event MethodAddTo SportNews;
        private event MethodAddTo SubscribeEventsNews;
        private event MethodAddTo Humor;
        public void Subscribe(Category id, Subscriber sub)
        {
            switch (id)
            {
                case Category.Weather:
                    Weather += sub.AddNews;
                    Console.WriteLine("Вы подписались на категорию \"Погода\"");
                    break;
                case Category.News:
                    SubscribeNews += sub.AddNews;
                    Console.WriteLine("Вы подписались на категорию \"Новости\"");
                    break;
                case Category.SportNews:
                    SportNews += sub.AddNews;
                    Console.WriteLine("Вы подписались на категорию \"Новости спорта\"");
                    break;
                case Category.EventsNews:
                    SubscribeEventsNews += sub.AddNews;
                    Console.WriteLine("Вы подписались на категорию \"Происшествия\"");
                    break;
                case Category.Humor:
                    Humor += sub.AddNews;
                    Console.WriteLine("Вы подписались на категорию \"Юмор\"");
                    break;
                default:
                    Console.WriteLine("Такой категории не существует!");
                    break;
            }
        }
        public void Desubscribe(Category id, Subscriber sub)
        {
            switch (id)
            {
                case Category.Weather:
                    Weather -= sub.AddNews;
                    Console.WriteLine("Вы отписались от категории \"Погода\"");
                    break;
                case Category.News:
                    SubscribeNews -= sub.AddNews;
                    Console.WriteLine("Вы отписались от категории \"Новости\"");
                    break;
                case Category.SportNews:
                    SportNews -= sub.AddNews;
                    Console.WriteLine("Вы отписались от категории \"Новости спорта\"");
                    break;
                case Category.EventsNews:
                    SubscribeEventsNews -= sub.AddNews;
                    Console.WriteLine("Вы отписались от категории \"Происшествия\"");
                    break;
                case Category.Humor:
                    Humor -= sub.AddNews;
                    Console.WriteLine("Вы отписались от категории \"Юмор\"");
                    break;
                default:
                    Console.WriteLine("Такой категории не существует!");
                    break;
            }
        }
        public void AddNews(Category id, string str)
        {
            switch (id)
            {
                case Category.News:
                    if (SubscribeNews != null)
                    {
                        SubscribeNews(str);
                    }
                    break;
                case Category.Weather:
                    if (Weather != null)
                    {
                        Weather(str);
                    }
                    break;
                case Category.SportNews:
                    if (SportNews != null)
                    {
                        SportNews(str);
                    }
                    break;
                case Category.EventsNews:
                    if (SubscribeEventsNews != null)
                    {
                        SubscribeEventsNews(str);
                    }
                    break;
                case Category.Humor:
                    if (Humor != null)
                    {
                        Humor(str);
                    }
                    break;
                default:
                    Console.WriteLine("Такой категории не существует!");
                    break;
            }
        }
    }
    class Subscriber : System.Collections.IEnumerable
    {
        private System.Collections.Specialized.StringCollection Data;

        public Subscriber()
        {
            Data = new System.Collections.Specialized.StringCollection();
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return ((System.Collections.IEnumerable)Data).GetEnumerator();
        }
        public void AddNews(string str)
        {
            Data.Add(str);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Operator oper = new Operator();
            Subscriber subs = new Subscriber();
            Subscriber subscriber = new Subscriber();
            Console.WriteLine($"--------Подписчик №1---------");
            oper.Subscribe(Category.Weather, subs);
            oper.Subscribe(Category.Humor, subs);
            oper.Desubscribe(Category.Weather, subs);
            Console.WriteLine($"--------Подписчик №2---------");
            oper.Subscribe(Category.News, subscriber);
            oper.Subscribe(Category.EventsNews, subscriber);
            oper.Desubscribe(Category.EventsNews, subscriber);
            oper.AddNews(Category.News, "Повысились цены на обучение!");
            oper.AddNews(Category.SportNews, "В колледже проходил турнир по настольному теннису");
            oper.AddNews(Category.Weather, "На улице холодно, зима ведь");
            oper.AddNews(Category.Humor, "Заходит улитка в бар и говорит бармену 'дайте виски с колой'");
            oper.AddNews(Category.EventsNews, "Рядом с колледжем была авария");
            Console.WriteLine();
            Console.WriteLine($"--------Подписчик №1---------");
            Console.WriteLine("          РАССЫЛКА            ");
            foreach (string str in subs)
            Console.WriteLine($"{str}");
            Console.WriteLine($"--------Подписчик №2---------");
            Console.WriteLine("          РАССЫЛКА            ");
            foreach (string str in subscriber)
            Console.WriteLine($"{str}");
            Console.ReadKey();
        }
    }
}


