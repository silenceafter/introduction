using System;

namespace homeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string username = Console.ReadLine();
            Console.WriteLine($"Привет, {username}, сегодня {DateTime.Now.ToShortDateString()}");
            Console.ReadKey();
        }
    }
}
