//
//  1. Вывод в консоль 
//  2. Объявление переменных 
//  3. Считывание данных из консоли
//  4. Конвертация строки. Класс Convert
//

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //  1. Вывод в консоль 

            Console.WriteLine("Hello world!");
            Console.WriteLine("Привет мир!!!");

            //  2. Объявление переменных

            int a;
            int b, c;

            // Инициализация 

            b = 2;
            c = 3;
            int d = 4;
            a = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            //  3. Считывание данных из консоли
            //  Считываются только строки!!!

            string data;
            data = Console.ReadLine();
            Console.WriteLine("Привет "+ data+"!!!");

            //  4. Конвертация строки. Класс Convert

            string str = "555";
            int e = Convert.ToInt32(str);

            // При выводе в консоль строки и числа одновременно 
            // ставится знак + (конкатенация) и число выводится
            // как символ или строка

            Console.WriteLine("Символ 555 конвертирован в число "+ e);

            string str1 = "1,9"; 
            double f = Convert.ToDouble(str1);
            Console.WriteLine("Символ 1,9 конвертирован в число " + f);
        }

    }
}
