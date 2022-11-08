using System;
using System.Security.Cryptography;

namespace Part2
{
    internal class Entry
    {
        private string name;
        private int number;
        private int[] date = new int[3];
        public Entry()
        {
            Console.WriteLine("Введите имя фамилия");
            name = Console.ReadLine();
            Console.WriteLine("Введите номер телефона начиная с кода оператора");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите день рождения");
            date[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите месяц рождения");
            date[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите год рождения");
            date[2] = Convert.ToInt32(Console.ReadLine());
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public int this[int i]
        {
            get
            {
                return date[i];
            }
            set
            {
                date[i] = value;
            }
        }
        public int[] Date()
        {
            return date;
        }
        public void print()
        {
            Console.Write($"name {name}\nnumber {number}\ndate ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(date[i] + " ");
            }
        }
    }
    internal class book
    {
        private Entry[] mass;
        private int size;
        public book(int x)
        {
            mass = new Entry[x];
            size = x;
        }
        public Entry this[int index]
        {
            get { return mass[index]; }
            set { mass[index] = value; }
        }
        public void searchNum(int x)
        {
            int pass = -1;
            for (int i = 0; i < size; i++)
            {
                if (mass[i].Number == x)
                {
                    pass = i;
                    break;
                }
            }
            if (pass != -1)
            {
                mass[pass].print();
            }
            else
            {
                Console.WriteLine("данный пользователь не найден");
            }
        }
        public void searchData(int[] mas)
        {
            int pass = -1;
            for(int i = 0; i < size;i++)
            {
                if (mas.ToString() == mass[i].Date().ToString())
                {
                    pass = i;
                    break;
                }
            }
            if (pass != -1)
            {
                mass[pass].print();
            }
            else
            {
                Console.WriteLine("данный пользователь не найден");
            }
        }
    }
}
