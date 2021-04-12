using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            // Приветствие
            Console.WriteLine(GetConfigParameter("greetings"));
            // Хранить данные?
            Console.WriteLine("Стереть данные в app.config? y/n");
            if (Console.ReadLine().ToLower() == "y")
            {
                // y
                EraseConfig();
            }

            // Основные параметры
            value = GetConfigParameter("name");
            if (string.IsNullOrEmpty(value))
            {
                SetConfigParameter("name");
            }
            else
            {
                Console.WriteLine("Пользователь: " + value);
            }
            
            //
            value = GetConfigParameter("age");
            if (string.IsNullOrEmpty(value))
            {
                SetConfigParameter("age");
            }
            else
            {
                Console.WriteLine("Возраст: " + value);
            }
            //
            value = GetConfigParameter("occupation");
            if (string.IsNullOrEmpty(value))
            {
                SetConfigParameter("occupation");
            }
            else
            {
                Console.WriteLine("Род деятельности: " + value);
            }
            Properties.Settings.Default.Save();
            Console.ReadKey();
        }

        static string GetConfigParameter(string name)
        {
            string value;
            switch (name)
            {
                case "age":
                    value = Properties.Settings.Default.age;                   
                    break;

                case "greetings":
                    value = Properties.Settings.Default.greetings;   
                    break;

                case "name":
                    value = Properties.Settings.Default.name;
                    break;

                case "occupation":
                    value = Properties.Settings.Default.occupation;
                    break;

                default:
                    Console.WriteLine("Параметр " + name + " не найден");
                    value = "";
                    break;
            }
            return value;
        }

        static void SetConfigParameter(string name)
        {         
            switch (name)
            {
                case "age":
                    Console.Write("Возраст: ");
                    Properties.Settings.Default.age = Console.ReadLine();
                    break;

                case "name":
                    Console.Write("Имя пользователя: ");
                    Properties.Settings.Default.name = Console.ReadLine();
                    break;

                case "occupation":
                    Console.Write("Род деятельности: ");
                    Properties.Settings.Default.occupation = Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Параметр " + name + " не найден");
                    break;
            }
            return;
        }

        static void EraseConfig()
        {
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                Properties.Settings.Default[currentProperty.Name] = "";
                Properties.Settings.Default.Save();
            }
            return;
        }
    }
}
