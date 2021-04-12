using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ряда Фибоначчи: ");
            Console.WriteLine($"n = {GetFibonacci(Convert.ToInt32(Console.ReadLine()))}");
        }

        static int GetFibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            return GetFibonacci(number - 1) + GetFibonacci(number - 2);
        }
    }
}
