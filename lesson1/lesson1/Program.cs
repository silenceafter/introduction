using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество повторений: ");
            int repeat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i <= repeat; i++)
            {
                Console.WriteLine($"Шаг: {i}");
                Console.Write("Введите имя: ");
                string userName = Console.ReadLine();
                Console.Write("Введите отчество: ");
                string userPatronymic = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                string userSurname = Console.ReadLine();
                //
                Console.WriteLine(GetFullName(userName, userSurname, userPatronymic));               
            }
            Console.ReadKey();
        }

        static string GetFullName(string firstName, string lastName, string patronymic) 
        {
            return $"Результат: {firstName} {patronymic} {lastName}\n";
        }
    }
}
