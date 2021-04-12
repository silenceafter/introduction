using System;
using System.Collections.Generic;
using System.IO;

namespace lesson4_2
{
    class Program
    { 
        static string filename = "lesson4_2.txt";
        static void Main(string[] args)
        {
            // 4. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без
            // вариант 2 без рекурсии            
            Console.WriteLine("Введите директорию:");
            string mypath = Console.ReadLine();
            File.AppendAllText(filename,$"{mypath}\n");
            //
            if (Directory.Exists(mypath))
            {
                string[] dir;
                string[] dirAll = Directory.GetDirectories(mypath);
                Stack<string> tree = new Stack<string>();
                GetMyFiles(mypath);
                //                
                for (int i = 0; i < dirAll.Length; i++)
                {
                    Console.WriteLine(dirAll[i]);
                    File.AppendAllText(filename,$"{dirAll[i]}\n");
                    GetMyFiles(dirAll[i]);
                    tree.Push(dirAll[i]);
                    do
                    {
                        dir = Directory.GetDirectories(tree.Pop());
                        for (int j = 0; j < dir.Length; j++)
                        {
                            Console.WriteLine("- " + dir[j]);
                            File.AppendAllText(filename, $"- {dir[j]}\n");
                            GetMyFiles(dir[j]);
                            tree.Push(dir[j]);
                        }
                    } while (tree.Count > 0);
                }
            }
            Console.ReadKey();
        }    

        static void GetMyFiles(string mypath)
        {
            string[] filesAll = Directory.GetFiles(mypath);
            for (int i = 0; i < filesAll.Length; i++)
            {
                Console.WriteLine("- " + filesAll[i]);
                File.AppendAllText(filename,$"- {filesAll[i]}\n");
            }
            return;
        }
    }
}
