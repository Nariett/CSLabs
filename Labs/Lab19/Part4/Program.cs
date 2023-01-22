using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Security.Cryptography;

namespace Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] music = { "YEEI", "Calmer", "Molitva" };
            string[] author = { "Alblak 52", "Friendly Thug 52 NGG", "Any act" };
            string[] disk = { "1", "2", "3" };
            MusicCatalog t1 = new MusicCatalog(music, author);
            MusicCatalog t2 = new MusicCatalog(music.Select(x => $"{x} {rand.Next(0, 10)}").ToArray(), author);
            MusicCatalog t3 = new MusicCatalog(music.Select(x => $"{x} {rand.Next(0, 10)}").ToArray(), author);
            HashMusicCatalog hash = new HashMusicCatalog(disk, new MusicCatalog[] { t1, t2, t3 });
            int p = 0;
            do
            {
                Console.WriteLine("0 - Добавить диск\n1 - Удалить диск\n2 - Добавить песню\n3 - Удалить песни\n4 - Посмотреть каталог\n5 - Посмотреть диск\n6 - Посмотреть все треки исполнителя\n7 - Выход из программы");
                int m = Convert.ToInt32(Console.ReadLine());
                switch (m)
                {
                    case 0:
                        {
                            Console.WriteLine("Введите название диска: ");
                            string nameDisk = Console.ReadLine();
                            Console.WriteLine("Введите кол-во треков: ");
                            int size = Convert.ToInt32(Console.ReadLine());
                            string[] track = new string[size];
                            string[] auth = new string[size];
                            for (int i = 0; i < track.Length; i++)
                            {
                                int q = i+1;
                                Console.WriteLine($"Введите трек: {q}");
                                track[i] = Console.ReadLine();
                                Console.WriteLine($"Введите автора трека: {q}");
                                auth[i] = Console.ReadLine();
                            }
                            MusicCatalog t = new MusicCatalog(track, auth);
                            hash.AddDisk(nameDisk,t);
                            Console.WriteLine("Диск добавлен в каталог ");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Введите диск который надо удалить: ");
                            string name = Console.ReadLine();
                            hash.RemoveDisk(name);
                            Console.WriteLine("Диск удален");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите диск в котором хотите добавить трек: ");
                            string numDisk = Console.ReadLine();
                            Console.WriteLine("Введите трек, который хотите добавить: ");
                            string nameMusic = Console.ReadLine();
                            Console.WriteLine("Введите имя исполнителя: ");
                            string auth = Console.ReadLine();
                            hash.AddMusic(numDisk, nameMusic, auth);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите диск в котором хотите удалить трек: ");
                            string numDisk = Console.ReadLine();
                            Console.WriteLine("Введите трек, который хотите удалить: ");
                            string nameMusic = Console.ReadLine();
                            hash.RemoveMusic(numDisk, nameMusic);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Все диски: ");
                            hash.ShowAllMusicFromCatalogMusic();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите название диска который хотите просмотреть: ");
                            string num = Console.ReadLine();
                            hash.ShowAllMusicFromDisk(num);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Введите исполнителя треки которого хотите просмотреть: ");
                            string name = Console.ReadLine();
                            hash.ShowAllMusicOfAuthor(name);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка ввода. Повторите попытку.");
                            break;
                        }
                }

            }
            while (p == 0);
            Console.ReadKey();
        }
    }
}
