using System;

namespace lesson3
{
    class Program
 {
        public enum Seasons
        { // времена года
            Зима = 1,
            Весна = 2,
            Лето = 3,
            Осень = 4
        }
   
        static void Main(string[] args)
        {
            int mymonth;
            do
            {
                Console.Write("Введите номер месяца: ");
                mymonth = Convert.ToInt32(Console.ReadLine());

                if (mymonth <= 0 || mymonth > 12)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                } else
                { 
                    break;
                }
            } while (true);

            Console.WriteLine($"Время года: {GetNameOfSeason(GetNumberOfSeason(mymonth))}");
            Console.ReadKey();
        }

        static int GetNumberOfSeason(int month)
        {
            int season = 0;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = (int) Seasons.Зима;
                    break;

                case 3:
                case 4:
                case 5:
                    season = (int)Seasons.Весна;
                    break;

                case 6:
                case 7:
                case 8:
                    season = (int)Seasons.Лето;
                    break;

                case 9:
                case 10:
                case 11:
                    season = (int)Seasons.Осень;
                    break;
            }             
            return season;
        }

        static string GetNameOfSeason(int season)
        {
            Seasons seasonName = (Seasons)season;            
            return seasonName.ToString();
        }
    }
}
