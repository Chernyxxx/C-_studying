//
//                              1  Найти минимальный эл-т массива 
//                              2  Найти индекс минимального эл-та массива
//                              3  Найти элемент в массиве по значению и вернуть его индекс
//                              4  Изменить размер массива
//                              

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Homework_Arrays
{
    class Program
    {
        //
        //                    1  Найти минимальный эл-т массива
        //

        static int MinElem(int [] array)
        {
            int minElem = array[0];
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]<minElem)
                {
                    minElem = array[i];
                }
            }
            return minElem;
        }

        //
        //                    2  Найти индекс минимального эл-та массива
        //
        static int IndexMinElem(int [] array)
        {
            int minElem = array[0];
            int index=0;
            for(int i=0; i<array.Length; i++)
            {
                if(array[i]<minElem)
                {
                    minElem = array[i];
                    index = i;
                }
            }
            return index;
        }

        //
        //              3  Найти элемент в массиве по значению и вернуть его индекс
        //

        static int FindElem(int[] array, int value)
        {
            int index = -1; // Метод возвращает -1 если эл-т не найден
            for(int i=0; i<array.Length; i++)
            {
                if(array[i]==value)
                {
                    index = i;
                    return index; 
                }
            }
            return index;
            
        }

        //
        //                      4  Изменить размер массива 
        // Массив является классом - ссылочным типом данных , поэтому он по умолчанию передаётся
        // в метод по ссылке. Но так как мы внутри метода создаём новый массив в куче, то необхо-
        // димо изменить исходную ссылку, чтобы она ссылалась на новый массив. Ссылка переданная
        // параметром в массив является копией исходной ссылки, и после выполнения метода уничтож-
        // ается. Поэтому необходимо передавать ссылку на массив в метод по ссылке - с ключевым
        // словом ref. В таком слуае исходная ссылка будет переподвязана к новому массиву.
        // 
        static void Resize(ref int[] arr, int newSize)
        {
            int[] newArray = new int[newSize];
            for(int i=0; i<arr.Length && i<newArray.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
        }

        //
        //                        5 Добавить новый эл-т в массив по индексу
        //  Так же как и в предыдущем случае необходимо использование ключ слова ref т.к. внутри
        //  метода создаётся новый массив и необходимо переподвязать исходную ссылку.

        static void InsertByIndex(ref int[] array, int newData, int index)
        {
            int[] newArray = new int[array.Length+1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            newArray[index] = newData;
            for (int i = index; i < array.Length; i++)
            {
                newArray[i+1] = array[i];
            }
            array = newArray;
        }

        static void Main(string[] args)
        {
            int[] arr = new[] {2,6,2};
 

            Console.WriteLine("\nМИНИМАЛЬНЫЙ ЭЛ-Т");
            int minElem = MinElem(arr);
            Console.WriteLine(minElem);


            Console.WriteLine("\nИНДЕКС МИНИМАЛЬНОГО ЭЛ-ТА");
            int index = IndexMinElem(arr);
            Console.WriteLine(index);


            Console.WriteLine("\nНАЙТИ ПО ЗНАЧЕНИЮ");
            int index1 = FindElem(arr, 6);
            Console.WriteLine(index1);

            Console.WriteLine("\nИЗМЕНИТЬ РАЗМЕР МАССИВА");
            Resize(ref arr, 2);

            Console.WriteLine("\nВСТАВИТЬ ПО ИНДЕКСУ");
            InsertByIndex(ref arr, 100, 0);
        }

    }
}
