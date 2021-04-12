using System;

namespace homeWork2_lesson2
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
            Console.Write("Введите порядковый номер текущего месяца = ");
            int mymonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Это {(Months)mymonth}");
            Console.ReadKey();
        }
    }
}
