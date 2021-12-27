//  1. Метод Parse
//  2. Метод TryParse
//  3. Класс Convert
//
// Методы Parse и TryParse находятся в классах простых типов данных (int, double
// и т.д.). Предназначены для перевода строк в соответствующие типы данных.
// Класс Convert конвертирует любые типы данных в любые типы данных.

using System;
using System.Globalization;

namespace _02_Parse_Tryparse_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //  1. Метод Parse
            //
            //

            // Если целую часть от дробной отделяет ЗАПЯТАЯ, метод Parse работает
            // корректно. 

            string str = "5,9";
            double a = double.Parse(str);


            // Если целую часть от дробной отделяет ТОЧКА, то надо
            // настроить объект класса NumberFormatInfo.
            // Класс NumberFormatInfo расположен в пространстве имён
            // System.Globalization. Объект этого класса нужно передать
            // вторым параметром в метод Parse

            string str1 = "5.9";

            NumberFormatInfo nfi = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double b = double.Parse(str1, nfi);

            // В случае если строка включает символы отличные от цифр, точек,
            // запятых, или другие символы не указанные в объекте класса
            // NumberFormatInfo,метод не сможет перевести данную строку в
            // число и возникнет исключение. Чтобы предотвратить такую ситуацию 
            // с методом Parse нужно использовать Try-Catch.
            //
            string str2 = "5,9";
            try
            {
                double c = double.Parse(str2);
                Console.WriteLine("Метод Parse" + "\n" +
                    "Успешная конвертация. " + "c = " + c);
            }
            catch (Exception)
            {
                Console.WriteLine("Метод Parse" + "\n" + "Неудачная конвертация");
            }

            //  2. TryParse
            //
            // Метод TryParse принимает 2 параметра: 1) строку которую требуется 
            // конвертировать, 2) переменную числового типа с модификатором out. 
            // В случае успешной конвертации в данную переменную будет записано
            // значение из строки, а в случае неудачной конвертации останется 0.
            // Метод TryParse возвращает тип данных bool. Если успешно, то true,
            // если неудачно то false.
            //
            //
            string str3 = "4";
            int d;
            bool result = int.TryParse(str3, out d);
            if (result)
            {
                Console.WriteLine
                    ("Метод TryParse" + "\n" + "Успешная конвертация. " + "d = " + d);
            }
            else
            {
                Console.WriteLine
                    ("Метод TryParse" + "\n" + "Неудачная конвертация");
            }
            //
            //
            //  3. Convert
            //
            // Конвертирует все типы данных. При необходимости так же можно 
            // использовать NumberFormatInfo.
            //
            //
            string str4 = "55";
            try
            {
                int e = Convert.ToInt16(str4);
                Console.WriteLine("Класс Convert" + "\n" +
                    "Успешная конвертация. " + "e = " + e);
            }
            catch (Exception)
            {
                Console.WriteLine("Класс Convert" + "\n" + "Неудачная конвертация");
            }

            string f = Convert.ToString(10);
            Console.WriteLine("Класс Convert" + "\n" + "Получена строка " + f);
        }
    }
}
