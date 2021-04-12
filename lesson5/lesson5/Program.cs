using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace lesson5
{
    class Program
    {
        static int cntTask = 0;
        static List<ToDo> mylist = new List<ToDo>();
        static int ShowConsoleMenu()
        {
            // отобразить глвное меню/получить ответ от пользователя
            int answer;
            Console.WriteLine("1 - Показать список, 2 - Добавить задачу, 3 - Сохранить список, 4 - Найти задачу, 5 - Выход.");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.Write("Ваш выбор: ");
            answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            return answer;
        }
        static void AddMyTask()
        {
            // добавить задачу
            Console.WriteLine($"Задание {++cntTask}");
            ToDo todo = new ToDo(Console.ReadLine());
            mylist.Add(todo);
            Console.WriteLine("Задание добавлено");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            return;
        }
        static void ToXml()
        {
            // сохранить список
            StringWriter stringWriter = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(typeof(List<ToDo>));
            serializer.Serialize(stringWriter, mylist);
            string xml = stringWriter.ToString();
            File.WriteAllText("tasks.xml", xml);
            Console.WriteLine("Сохранено");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            return;
        }

        static void FromXml()
        {
            if (File.Exists("tasks.xml"))
            {
                // загрузить список
                string xmlText = File.ReadAllText("tasks.xml");
                StringReader stringReader = new StringReader(xmlText);
                XmlSerializer serializer = new XmlSerializer(typeof(List<ToDo>));
                mylist = (List<ToDo>)serializer.Deserialize(stringReader);
                Console.WriteLine("Список задач");
                Console.WriteLine("--------------------------------------------------------------------------------------------");

                ShowToDoList();
            }
            else
            {
                Console.WriteLine("Файл\"tasks.xml\" не найден");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            return;
        }

        static void DoMyTask()
        {
            Console.Write("Введите номер задания: ");
            int number = Convert.ToInt32(Console.ReadLine());
            foreach (ToDo task in mylist)
            {
                if (number == mylist.IndexOf(task) + 1)
                {
                    if (task.IsDone) 
                    {
                        task.IsDone = false;
                        Console.WriteLine($"Задание {number} не выполнено");
                    } else
                    {
                        task.IsDone = true;
                        Console.WriteLine($"Задание {number} выполнено");
                    }
                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                    break;
                }
            }
            return;
        }

        static void ShowToDoList()
        {
            int cntTask = 1;
            foreach (ToDo task in mylist)
            {
                Console.WriteLine($"Задание {cntTask}: ");
                Console.WriteLine($"Название: {task.Title}");
                string isDone = task.IsDone == true ? "Выполнено: да" : "Выполнено: нет";
                if (task.IsDone)
                {
                    Console.WriteLine("[x]");
                }
                Console.WriteLine(isDone);
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                cntTask++;
            }
            return;
        } 

        static void Main(string[] args)
        {
            int answer = 0;
            // получить список задач
            FromXml();
            do
            {
                answer = ShowConsoleMenu();
                // Console.WriteLine("");

                switch (answer)
                {
                    case 1:
                        ShowToDoList();
                        break;

                    case 2:
                        AddMyTask();
                        break;

                    case 3:
                        ToXml();
                        break;

                    case 4:
                        DoMyTask();
                        break;

                    case 5:
                        break;
                }
            } while (answer != 5);
        }
    }
}
