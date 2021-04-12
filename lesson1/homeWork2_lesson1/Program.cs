using System;

namespace homeWork2_lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
             // минимальная температура
             Console.Write("Введите минимальную температуру за сутки = ");
             float minTemperature = float.Parse(Console.ReadLine());                
             // максимальная температура
             Console.Write("Введите максимальную температуру за сутки = ");
             float maxTemperature = float.Parse(Console.ReadLine());
             // средняя температура
             Console.Write($"Средняя температура за сутки = {(minTemperature + maxTemperature) / 2}");
             Console.ReadKey();
        }
    }
}
