using System;
using System.IO;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            Console.Write("Напишите что-нибудь: ");
            string mytext = Console.ReadLine();
            Console.Write("Введите имя текстового файла (с расширением .txt): ");
            string filename = Console.ReadLine();
            //
            File.WriteAllText(filename, mytext);
            Console.WriteLine($"Файл {filename} сохранен");
        }
    }
}
