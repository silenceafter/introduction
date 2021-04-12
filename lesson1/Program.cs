using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл
            Console.WriteLine("Введите числа от 0 до 255 через пробел: ");
            string number = Console.ReadLine();
            string[] numbers = number.Split(' ');
            string filename = "file.bin";
            //
            byte[] array = new byte[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = Convert.ToByte(numbers[i]);
            }
            File.WriteAllBytes(filename, array);
            Console.ReadKey();
        }
    }
}
