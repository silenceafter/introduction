using System;

namespace homeWork2_lesson6
{
    class Program
    {
        public enum Week
        {
            Ничего = 0b_0000000,         // 0
            Понедельник = 0b_0000001,    // 1
            Вторник = 0b_0000010,        // 2
            Среда = 0b_0000100,          // 4
            Четверг = 0b_0001000,        // 8
            Пятница = 0b_0010000,        // 16
            Суббота = 0b_0100000,        // 32
            Воскресенье = 0b_1000000     // 64
        }

        static void Main(string[] args)
        {
            string myanswer;
            do
            {
                Console.Write("Введите номер дня недели: "); // 1.ввели день недели
                int dayNumber = Int32.Parse(Console.ReadLine());
                // узнать, работает офис в этот день
                Week office1Mask = Week.Вторник | Week.Среда | Week.Четверг | Week.Пятница;
                Week office2Mask = Week.Понедельник | Week.Вторник | Week.Среда | Week.Четверг | Week.Пятница | Week.Суббота | Week.Воскресенье;
                Week dayChar = (Week)Enum.GetValues(typeof(Week)).GetValue(dayNumber); // день недели (численное значение Week) -> день недели (константа Week)
                //
                Week worksThatDay1 = office1Mask & dayChar;
                Week worksThatDay2 = office2Mask & dayChar;
                bool isOpen1 = worksThatDay1 == dayChar;
                bool isOpen2 = worksThatDay2 == dayChar;

                string workStatus1, workStatus2;
                // офис 1
                if (isOpen1)
                {
                    workStatus1 = "работает";
                }
                else
                {
                    workStatus1 = "не работает";
                }
                // офис 2
                if (isOpen2)
                {
                    workStatus2 = "работает";
                }
                else
                {
                    workStatus2 = "не работает";
                }
                Console.WriteLine($"Офис 1 {workStatus1} в {dayChar}. Офис 2 {workStatus2} в {dayChar}");
                Console.WriteLine("Выйти из программы? y - да, n - нет");
                myanswer = Console.ReadLine();
            } while (myanswer == "n" || myanswer == "N");
        }
    }
}
