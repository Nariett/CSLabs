using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class DoubleArr <T> 
    {
        public T[] arr;
        public T[] Arr
        {
            get { return arr; }
        }
        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                this.Arr[index] = value;
            }
        }
        public DoubleArr(T[] arr)
        {
            this.arr = arr;
        }
        public override string ToString()
        {
            string x = "";
            for (int i = 0; i < arr.Length; i++)
            {
                x += arr[i] + " "; 
            }
            return x;
        }
        public static bool operator ==(DoubleArr<T> a,DoubleArr<T> b)
        {
            if (a.Arr.Length != b.Arr.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < a.Arr.Length; i++)
                {
                    if (!a[i].Equals(b[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool operator !=(DoubleArr<T> a, DoubleArr<T> b)
        {
             if (a.Arr.Length != b.Arr.Length)
             {
                 return true;
             }
             else
             {
                 for (int i = 0; i < a.Arr.Length; i++)
                 {
                     if (a[i].Equals(b[i]))
                     {
                         return false;
                     }
                 }
                 return true;
             }
       }
        public static DoubleArr<T> operator ++(DoubleArr<T> a)
        {
            for(int i = 0; i < a.Arr.Length;i++)
            {
                a.Arr[i] = (dynamic)a.Arr[i]+1;
            }
            return a;
        }
        public static DoubleArr<T> operator --(DoubleArr<T> a)
        {
            for (int i = 0; i < a.Arr.Length; i++)
            {
                a.Arr[i] = (dynamic)a.Arr[i] - 1;
            }
            return a;
        }
        ~DoubleArr()
        {
            Console.WriteLine("Класс удален");
        }
    }
}
