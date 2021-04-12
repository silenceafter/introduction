using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook = new string[5,2];
            phoneBook[0,0] = "Иван Иванович Иванов"; //1 - имя контакта
            phoneBook[0,1] = "9011230102"; //2 - телефон/e-mail
            phoneBook[1,0] = "Петр Петрович Петров";
            phoneBook[1,1] = "a123@mail.ru";
            phoneBook[2,0] = "Иван Алексеевич Сидоров";
            phoneBook[2,1] = "9021230405";
            phoneBook[3,0] = "Сергей Анатольевич Дмитриев";
            phoneBook[3,1] = "9451452387";
            phoneBook[4,0] = "Алексей Дмитриевич Петров";
            phoneBook[4,1] = "you@gmail.com";
            
            int cnt = 1;
            for (int i = 0; i < phoneBook.GetLength(0); i++) 
            {
                Console.WriteLine($"{phoneBook[i,0]}, {phoneBook[i, 1]}");              
                cnt++;
            }
            Console.ReadKey();
        }
    }
}
