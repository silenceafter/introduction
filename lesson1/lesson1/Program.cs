using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[8,8];
            int cnt = 1;
            string column = "";
            // заполним значениями и выведем на экран
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j) {
                        array[i, j] = Convert.ToString(cnt);
                        cnt++;
                    } else
                    {
                        array[i, j] = " ";
                    }
                    column += $"{array[i,j]} "; 
                }
                Console.WriteLine($"{column}");
                column = "";
            }
            Console.ReadKey();
        }
    }
}
