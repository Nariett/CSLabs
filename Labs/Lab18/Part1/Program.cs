using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace Part1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Date da = new Date();
            Console.WriteLine($"Прошлый день: {da.pastData()}");
            Console.WriteLine($"Следующий день: {da.nextData()}"); ;
            Console.WriteLine($"Дней до конца месяца:{da.lastDay()}");
            Console.WriteLine($"День:{da[0]}\nМесяц: {da[1]}\nМесяц: {da[2]}");
            da[0] = 10;
            da[1] = 12;/////////////
            da[2] = 2004;
            

            // XML
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Date));
            using (FileStream fs = new FileStream("Date.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, da);

                Console.WriteLine("Обьект срелизован xml");
            }
            using (FileStream fs = new FileStream("Date.xml", FileMode.OpenOrCreate))
            {
                Date x = xmlSerializer.Deserialize(fs) as Date;
                Console.WriteLine($"дата: {x}");
            }
            //soap
            SoapFormatter formatter = new SoapFormatter();
            using (FileStream fs = new FileStream("Date.soap", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, da);

                Console.WriteLine("Объект сериализован soap");
            }

            // десериализация
            using (FileStream fs = new FileStream("Date.soap", FileMode.OpenOrCreate))
            {
                Date data = (Date)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"дата: {data}");
            }
            Console.ReadKey();

        }
    }
}
