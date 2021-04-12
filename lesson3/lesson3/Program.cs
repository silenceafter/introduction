using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string stringFromUser = Console.ReadLine();                      
            char[] charArray = stringFromUser.ToCharArray();
            //
            Console.Write("Обратный текст: ");
            for (int i = stringFromUser.Length - 1; i >= 0; i--) {
                Console.Write(stringFromUser[i]);
            }
            Console.ReadKey();
        }
    }
}
