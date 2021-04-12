using System;

namespace homeWork2_lesson5
{
    class Program
    {
        public enum Months
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        static void Main(string[] args)
        {
            // месяц
            Console.Write("Введите порядковый номер текущего месяца = ");
            int mymonth = Int32.Parse(Console.ReadLine());
            // минимальная температура
            Console.Write("Введите минимальную температуру: ");
            float minTemperature = float.Parse(Console.ReadLine());
            // максимальная температура
            Console.Write("Введите максимальную температуру: ");
            float maxTemperature = float.Parse(Console.ReadLine());
            // средняя температура
            float avgTemperature = (minTemperature + maxTemperature) / 2;

            if ((mymonth == 12 || mymonth >= 1 && mymonth <= 2) && avgTemperature > 0) {
                Console.WriteLine("Дождливая зима");
            }
            Console.WriteLine($"Это {(Months)mymonth}");

            if (avgTemperature > 0) { 
                Console.Write($"Средняя температура: +{avgTemperature}C");
            } else
            {
                Console.Write($"Средняя температура: {avgTemperature}C");
            }    
            Console.ReadKey();
        }
    }
}
