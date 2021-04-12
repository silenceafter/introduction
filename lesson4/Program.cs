using System;

namespace homeWork2_lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkNumber = "1123",
                companyName = "ООО Моя компания", 
                inn = "123456789100", 
                address = "г.Москва, ул.Майская, д.3",
                worker = "Иванов Иван Иванович",               
                systemTax = "Система налогообложения ОСНО",
                fiscalReceipt = "123445",
                codeKKT = "479949",
                fn = "88890",
                ofd = "Первый ОФД",
                site = "www.1-ofd.ru";
            string item1 = "Хлеб", item2 = "Масло сливочное", item3 = "Сыр Российский";
            float price1 = 40.0f, price2 = 100.9f, price3 = 254.34f;
            int number1 = 2, number2 = 1, number3 = 1;
            float ndsTax1 = 0.1f, ndsTax2 = 0.1f, ndsTax3 = 0.18f;
            int money = 500;

            string line = "", myspace = "     ";
            for (int i = 0; i < 40; i++)
            {
                line += "*";
            }

            // шапка
            Console.WriteLine($"Кассовый чек №{checkNumber}");
            Console.WriteLine($"{companyName}");
            Console.WriteLine($"ИНН {inn}");
            Console.WriteLine($"Адрес {address}");
            DateTime now = DateTime.Now;
            Console.WriteLine($"{now}");
            Console.WriteLine($"Кассир {worker}");
            // разделитель
            Console.WriteLine(line);
            // список товаров
            Console.WriteLine($"Товар: {item1}") ;
            Console.WriteLine($"{price1} * {number1} = {price1 * number1} руб.");
            Console.WriteLine($"НДС: {ndsTax1 * 100}%");
            Console.WriteLine("");
            Console.WriteLine($"Товар: {item2}");
            Console.WriteLine($"{price2} * {number2} = {price2 * number2} руб.");
            Console.WriteLine($"НДС: {ndsTax2 * 100}%");
            Console.WriteLine("");
            Console.WriteLine($"Товар: {item3}");
            Console.WriteLine($"{price3} * {number3} = {price3 * number3} руб.");
            Console.WriteLine($"НДС: {ndsTax3 * 100}%");
            Console.WriteLine("");
            //
            Console.WriteLine(line);
            // итог
            float total = price1 * number1 + price2 * number2 + price3 * number3;
            Console.WriteLine($"Итог: {total} руб.");
            Console.WriteLine($"Наличные: {money} руб.");
            Console.WriteLine($"Сдача: {Math.Round(money - total,2)} руб.");
            Console.WriteLine(line);
            // футер
            Console.WriteLine($"{systemTax}");
            Console.WriteLine($"Фискальный чек №{fiscalReceipt}");
            Console.WriteLine($"Код ККТ {codeKKT}");
            Console.WriteLine($"ФН {fn}");
            Console.WriteLine($"ОФД {ofd}");
            Console.WriteLine($"{site}");
        }
    }
}
