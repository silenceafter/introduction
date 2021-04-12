
using System;
using System.IO;

namespace lesson4_1
{
    class Program
    {
        static string filename = "lesson4_1.txt";
        static void Main(string[] args)
        {
            // 4. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без
            // вариант 1 с рекурсией            
            Console.WriteLine("Введите директорию:");
            string mypath = Console.ReadLine();
            File.AppendAllText(filename, $"{mypath}\n");
            
            if (Directory.Exists(mypath))
            {
                GetMyFiles(mypath);
                string[] dirAll = Directory.GetDirectories(mypath);
                for (int i = 0; i < dirAll.Length; i++)
                {
                    Console.WriteLine(dirAll[i]);
                    File.AppendAllText(filename, $"{dirAll[i]}\n");
                    GetMyDirectory(dirAll[i]);
                }
            }
        }

        static void GetMyDirectory(string mypath)
        {
            string[] dirAll = Directory.GetDirectories(mypath);
            GetMyFiles(mypath);// файлы
            // на уровень ниже         
            if (dirAll.Length > 0)// терминальное условие dirAll.Length = 0, т.к. не может быть бесконечной вложенности папок
            {
                for (int i = 0; i < dirAll.Length; i++)
                {
                    Console.WriteLine(dirAll[i]);
                    File.AppendAllText(filename, $"{dirAll[i]}\n");
                    GetMyDirectory(dirAll[i]);
                }
            }
            return;
        }

        static void GetMyFiles(string mypath)
        {
            string[] filesAll = Directory.GetFiles(mypath);
            for (int i = 0; i < filesAll.Length; i++)
            {
                Console.WriteLine($"- {filesAll[i]}");
                File.AppendAllText(filename, $"- {filesAll[i]}\n");
            }
            return;
        }
    }
}
