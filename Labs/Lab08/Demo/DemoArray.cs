using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class DemoArray
    {
        int[] MyArray;//закрытый массив
        string name; //закрытое поле
        public DemoArray(int size, int x, string name)//конструктор
        {
            MyArray = new int[size];
            this.name = name;
            for (int i = 0; i < size; ++i) MyArray[i] = x;
        }
        public int[] myArray
        {
            get
            {
                return MyArray;
            }
            set
            {
                MyArray = value;
            }
        }
        public void Print()//метод
        {
            Console.Write(name + ":");
            foreach (int a in MyArray) Console.Write(a + " ");
            Console.WriteLine();
        }
        public int LengthN //свойство
        {
            get { return MyArray.Length; }
        }
        public static DemoArray operator +(DemoArray a)
        {
            for(int i = 0;i < a.myArray.Length;i++)
            {
                a.myArray[i] = Math.Abs(a.myArray[i]); 
            }
            return a;
        }
        public static DemoArray operator -(DemoArray a)
        {
            for (int i = 0; i < a.myArray.Length; i++)
            {
                a.myArray[i] = a.myArray[i] - 1;
            }
            return a;
        }
        public static DemoArray operator -(DemoArray a,int b)
        {
            for (int i = 0; i < a.myArray.Length; i++)
            {
                a.myArray[i] = a.MyArray[i] - b;
            }
            return a;
        }
        public static bool operator &(DemoArray a,DemoArray b)
        {
            for (int i = 0; i < a.myArray.Length; i++)
            {
                if (a.myArray[i] != b.myArray[i])
                {
                    return false;
                }
            }
            return true;
        }
        ~DemoArray()//деструктор
        {
            Console.WriteLine(" сработал деструктор для объекта " +this.name);
        }

    }
}
