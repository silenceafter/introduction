using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lesson1
{
    class Program
    {
        static void KillMyProcessByID(int myprocess)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.Id == myprocess)
                {
                    try
                    {
                        process.Kill();
                    }
                    catch
                    {
                        Console.WriteLine($"Ошибка при завершении процесса по ID = {myprocess}");
                        PrintLine();
                    }
                }
            }
            Console.WriteLine($"Процесс {myprocess} завершен");
            PrintLine();
        }

        static void KillMyProcessByName(string myprocess)
        {
            foreach (Process process in Process.GetProcessesByName(myprocess))
            {
                try
                {
                    process.Kill();
                }
                catch
                {
                    Console.WriteLine($"Ошибка при завершении процесса {myprocess}");
                    PrintLine();
                }
            }
            Console.WriteLine($"Процесс {myprocess} завершен");
            PrintLine();
        }

        static void ShowMyList()
        {
            // вывести процессы            
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"Процесс: {process.ProcessName}, PID: {process.Id}");
            }
            PrintLine();
        }

        static void PrintLine()
        {
            Console.WriteLine("--------------------------------------------------------------------");
        }
        static void Main(string[] args)
        {
            // вывести процессы            
            ShowMyList();
            int answer = 0;
            //
            do
            {
                Console.WriteLine("1 - Завершить процесс, 2 - Показать список процессов, 3 - Выход");
                Console.Write("Ваш ответ: ");
                answer = Convert.ToInt32(Console.ReadLine());
                PrintLine();

                switch (answer)
                {
                    case 1:
                        Console.WriteLine("1 - Завершить процесс по ID, 2 - Завершить процесс по имени процесса");
                        Console.Write("Ваш ответ: ");
                        answer = Convert.ToInt32(Console.ReadLine());
                        PrintLine();

                        if (answer == 1)
                        {
                            Console.Write("ID: ");
                            int myProcessID = Convert.ToInt32(Console.ReadLine());
                            PrintLine();
                            KillMyProcessByID(myProcessID);
                        }
                        else if (answer == 2)
                        {
                            Console.Write("Имя процесса: ");
                            string myProcessName = Console.ReadLine();
                            PrintLine();
                            KillMyProcessByName(myProcessName);
                        }
                        break;

                    case 2:
                        ShowMyList();
                        break;

                    case 3:
                        break;
                }
            } while (answer != 3);
        }
    }
}