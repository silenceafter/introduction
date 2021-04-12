using System;
using System.IO;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt»
            string filename = "startup.txt";
            string mytime = "\n" + DateTime.Now.ToString("HH:mm"); 
            File.AppendAllText(filename, mytime);
            // откроем и файл и выведем текст на экран
            string mytext = File.ReadAllText(filename);
            Console.WriteLine($"Файл {filename}:");
            Console.WriteLine(mytext);
        }
    }
}
