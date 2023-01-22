using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;

namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Coll[] array = new Coll[5]; 
            array[0] = new Coll("Ford", 1964, 5356, 120000, "John");
            array[1]= new Coll("Old", 1350, 1000, 110800, "Rosa");
            array[2] = new Coll("ring", 2000, 0.05, 140700, "Lisa");
            array[3] = new Coll("Book", 1888, 1000, 99911, "Nick");
            array[4] = new Coll("PC", 1999, 5000, 10099, "Sasha");
            double aver = 0;
            for (int i = 0; i < array.Length; i++)
            {
                aver += array[0].Price;
            }
            aver = aver/ array.Length;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i].Price >= aver)
                {
                    count++;
                }
            }
            Console.WriteLine($"Самые дорогие вещи: {count}");
            //bin
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Coll.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, array);

                Console.WriteLine("Объект сериализован bin");
            }
            using (FileStream fs = new FileStream("Coll.dat", FileMode.OpenOrCreate))
            {
                Coll[] arr = (Coll[])formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                for(int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }
            //soap
            SoapFormatter formatte = new SoapFormatter();
            using (FileStream fs = new FileStream("Date.soap", FileMode.OpenOrCreate))
            {
                formatte.Serialize(fs, array);

                Console.WriteLine("Объект сериализован soap");
            }
            // десериализация
            using (FileStream fs = new FileStream("Date.soap", FileMode.OpenOrCreate))
            {
                Coll[] arr = (Coll[])formatte.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }
            Console.ReadLine();
        }

    }
}
