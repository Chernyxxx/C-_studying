//
//                                   Массивы
////                 Методы для работы с массивами System.Linq:
//      Length, Min, Max, Sum, Distinct, OrderBy, OrderByDistinct, First, Last.
//
//      Статические методы класса Array - Sort, Find, FindLast, FindAll, FindIndex,
//      FindIndexLast, Reverse 
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Arays_Methods
    {
        static void Main(string[] args)
        {
            int[] myArray = { 6, 65, 234, 87, 4, 5443, 789, 4, 87, 8, 234 };
            //
            //                        Length
            //      Возвращает количество эл-тов в массиве

            
            Console.WriteLine("There are " + myArray.Length+" elements in array");
            Console.WriteLine();

            //
            //                        Max и Min
            //


            int result = myArray.Max();

            Console.WriteLine("Max elem. - " + result);
            Console.WriteLine("Min elem. - " + myArray.Min());
            Console.WriteLine();

            //
            //                          Sum
            //
            //     Сумма всех элементов

            Console.WriteLine("Sum of all elem. - " + myArray.Sum());
            Console.WriteLine();

            //
            //                        Distinct, ToArray
            //
            //      Найти уникальные элементы и поместить их в новый массив

            int[] newArray = myArray.Distinct().ToArray();
            Console.WriteLine("Uniqe elements copied to new array - ");

            foreach (var item in newArray)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine(); Console.WriteLine();

            //
            //                        OrderBy, ToArray
            //                        
            //    Отсортировать элементы по возрастанию и поместить их в новый массив

            int[] sortArray = myArray.OrderBy(i=>i).ToArray();
            Console.WriteLine("Sorted elem copied to new array - ");

            foreach (var item in sortArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); Console.WriteLine();

            //
            //                        OrderByDescending, ToArray
            //                        
            //    Отсортировать элементы по убыванию и поместить их в новый массив

            int[] sort1Array = myArray.OrderByDescending(i => i).ToArray();
            Console.WriteLine("Sorted by descanding elem copied to new array - ");

            foreach (var item in sort1Array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); Console.WriteLine();

            //
            //                        Where, ToArray
            //                        
            //    Выбрать элементы по условию и поместить их в новый массив

            int[] sort2Array = myArray.Where(i=>i>100).ToArray();
            Console.WriteLine("Elem that more then 100 - ");

            foreach (var item in sort2Array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //                        Where, Sum
            //                        
            //    Выбрать элементы по условию и найти их сумму

            int result2 = myArray.Where(i => i > 100).Sum();
            Console.WriteLine("Sum of elem-s that more then 100 = "+result2);
            Console.WriteLine();

            //
            //                        Where, First, Last
            //                        
            //    Находит первый (First()) или последний элемент (Last())по условию 

            int res = myArray.Where(i => i > 100).Last();
            Console.WriteLine("Last elem-s that more then 100 = " + res);
            Console.WriteLine();

            //             Статические методы класса базового Array  
            //   Sort, Find, FindLast, FindAll, FindIndex, FindIndexLast, Reverse               
            //

            // Статический метод Sort cортирует массив без копирования

            Array.Sort(myArray);
            Console.WriteLine("Static method Sort");
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); Console.WriteLine();
        

        // Статический метод Find перебирает массив от начала и возвращает
        // первое подходящее число
        // FindLast перебирает массив с конца
        // FindAll находит все элементы соотв. условию и помещает их в новый массив

        int result3 = Array.Find(myArray, i => i > 100);
            Console.WriteLine("Static method Find "+ result3);
            Console.WriteLine();

            // Статический метод FindIndex возвращает индекс элемента
            // Если требуемого эл-та не существует, то метод возвращает -1
            // Если в массиве находится несколько подходящих эл-тов то
            // метод FindIndex вернёт индекс подходящего эл-та с начала.
            // Метод FindIndexLast вернёт индекс подходящего эл-та с конца.

            int index = Array.FindIndex(myArray, i => i == 5443);
            Console.WriteLine("Static method FindIndex " + index);
            Console.WriteLine();

            // Статический метод Reverse переставляет эл-ты наоборот
            Array.Reverse(myArray);
            Console.WriteLine("Static method Reverse ");
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); Console.WriteLine();
        }
    }  
}
