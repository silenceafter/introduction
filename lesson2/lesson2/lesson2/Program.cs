using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел и нажмите ENTER: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Сумма чисел: {GetSumOfNumbers(userInput)}");
        }

        static int GetSumOfNumbers(string userInput)
        {
            int sum = 0;
            string mynumber = "";
            userInput += " ";

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i].ToString() != " ")
                {
                    mynumber += Convert.ToInt32(userInput[i].ToString());             
                } else
                {
                    if (string.IsNullOrEmpty(mynumber)) { mynumber = "0"; }
                    sum += Convert.ToInt32(mynumber);
                    mynumber = "";
                }
            }

            return sum;
        }
    }
}
