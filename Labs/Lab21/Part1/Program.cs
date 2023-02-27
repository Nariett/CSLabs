using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Icon Photo = new Icon("Фотографии", new DateTime(2023, 12, 5), "C:\\Users\\sasha\\test.jpg", "Sasha");
            bool x = true;
            while (x)
            {
                Console.WriteLine("Выберите пункт меню:\n1 - Создание через XMLDoc\n2 - Чтение\n3 - Добавление объектов в XML\n4 - Удаление объектов из начала\n5 - Удаление объектов из конца\n6 - Работа с Xpath");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        {
                            XDocument xdoc = new XDocument();
                            XElement photoshop = new XElement("icon");
                            XAttribute photoshopName = new XAttribute("name", "Photoshop");
                            XElement photoshopDate = new XElement("date", "28/12/2019");
                            XElement photoshopPath = new XElement("path", "C:\\Users\\sasha\\Photoshop.jpg");
                            XElement photoshopUser = new XElement("user", "Sasha");
                            photoshop.Add(photoshopName);
                            photoshop.Add(photoshopUser);
                            photoshop.Add(photoshopDate);
                            photoshop.Add(photoshopPath);
                            XElement googleStore = new XElement("icon");
                            XAttribute googleStoreName = new XAttribute("name", "Google Store");
                            XElement googleStoreDate = new XElement("date", "12/05/2022");
                            XElement googleStorePath = new XElement("path", "C:\\Users\\sasha\\GoogleStore.jpg");
                            XElement googleStoreUser = new XElement("user", "Pasha");
                            googleStore.Add(googleStoreName);
                            googleStore.Add(googleStoreUser);
                            googleStore.Add(googleStoreDate);
                            googleStore.Add(googleStorePath);
                            XElement phones = new XElement("phones");
                            phones.Add(photoshop);
                            phones.Add(googleStore);
                            xdoc.Add(phones);
                            xdoc.Save("icon.xml");
                            Console.WriteLine("Создан объект");
                            break;
                        }
                    case 2:
                        {
                            List<Icon> people = new List<Icon>();
                            XmlDocument xDoc = new XmlDocument();
                            xDoc.Load("icon.xml");
                            XmlElement xRoot = xDoc.DocumentElement;

                            foreach (XmlNode xnode in xRoot)
                            {
                                Icon icon = new Icon();

                                if (xnode.Attributes.Count > 0)
                                {
                                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                                    if (attr != null)
                                        icon.name = attr.Value;

                                    Console.WriteLine(attr.Value);
                                }
                                foreach (XmlNode childnode in xnode.ChildNodes)
                                {

                                    if (childnode.Name == "name")
                                    {
                                        icon.name = childnode.InnerText;
                                        Console.WriteLine("Название: {0}", childnode.InnerText);
                                    }
                                    if (childnode.Name == "user")
                                    {
                                        icon.user = childnode.InnerText;
                                        Console.WriteLine("Пользователь {0}", childnode.InnerText);
                                    }

                                    if (childnode.Name == "date")
                                    {
                                        icon.date = Convert.ToDateTime(childnode.InnerText);
                                        Console.WriteLine("Дата: {0}", childnode.InnerText);
                                    }
                                    if (childnode.Name == "path")
                                    {
                                        icon.path = childnode.InnerText;
                                        Console.WriteLine("Место на диске: {0}", childnode.InnerText);
                                    }

                                }
                                people.Add(icon);
                                Console.WriteLine("Все элементы отображены");
                            }

                            break;
                        }
                    case 3:
                        {
                            XmlDocument xDoc = new XmlDocument();
                            xDoc.Load("icon.xml");
                            XmlElement xRoott = xDoc.DocumentElement;
                            XmlElement iconData = xDoc.CreateElement("icon");
                            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
                            XmlElement dateElem = xDoc.CreateElement("date");
                            XmlElement pathElem = xDoc.CreateElement("path");
                            Console.WriteLine("Введите имя");
                            XmlText nameText = xDoc.CreateTextNode(Console.ReadLine());
                            Console.WriteLine("Введите дату (дд//мм/год)");
                            XmlText dateText = xDoc.CreateTextNode(Console.ReadLine());
                            Console.WriteLine("Введите путь");
                            XmlText pathText = xDoc.CreateTextNode(Console.ReadLine());
                            nameAttr.AppendChild(nameText);
                            dateElem.AppendChild(dateText);
                            pathElem.AppendChild(pathText);
                            iconData.Attributes.Append(nameAttr);
                            iconData.AppendChild(dateElem);
                            iconData.AppendChild(pathElem);
                            xRoott.AppendChild(iconData);
                            xDoc.Save("icon.xml");
                            Console.WriteLine("Элемент добавлен");
                            break;
                        }
                    case 4:
                        {
                            XmlDocument xDoc = new XmlDocument();
                            xDoc.Load("icon.xml");
                            XmlElement xRoot = xDoc.DocumentElement;

                            XmlNode firstNode = xRoot.FirstChild;
                            xRoot.RemoveChild(firstNode);
                            xDoc.Save("icon.xml");

                            Console.WriteLine("Элемент удален");

                            break;
                        }
                    case 5:
                        {
                            XmlDocument xDoc = new XmlDocument();
                            xDoc.Load("icon.xml");
                            XmlElement xRoot = xDoc.DocumentElement;

                            XmlNode lastNode = xRoot.LastChild;
                            xRoot.RemoveChild(lastNode);
                            xDoc.Save("icon.xml");

                            Console.WriteLine("Элемент удален");
                            break;
                        }
                    case 6:
                        {
                            XmlDocument document = new XmlDocument();
                            document.Load("icon.xml");
                            XmlNodeList nodes =
                            document.DocumentElement.SelectNodes("//icon[date='12/05/2022']");
                            foreach (XmlNode node in nodes)
                            {
                                Console.WriteLine(node.InnerText);
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}
