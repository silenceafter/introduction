using System;

namespace homeWork2_lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mynumber;
            string myanswer;

            do
            {
                Console.Write("Введите число: ");
               mynumber = Int32.Parse(Console.ReadLine());
                //
                if (mynumber % 2 == 0)
                {
                    // число четное
                    Console.WriteLine($"{mynumber} - четное");
                }
                else
                {
                    // число нечетное
                    Console.WriteLine($"{mynumber} - нечетное");
                }
                Console.WriteLine("Выйти из программы? y - да, n - нет");
                myanswer = Console.ReadLine();
            } while (myanswer == "n" || myanswer == "N");
        }
    }
}
