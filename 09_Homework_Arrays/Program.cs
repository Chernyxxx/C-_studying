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
        //
        static void Resize(ref int [] arr, int newSize)
        {

        }
        static void Main(string[] args)
        {
            int[] arr = new[] {2,6,2,0,-8,9};


            Console.WriteLine("\nМИНИМАЛЬНЫЙ ЭЛ-Т");
            int minElem = MinElem(arr);
            Console.WriteLine(minElem);


            Console.WriteLine("\nИНДЕКС МИНИМАЛЬНОГО ЭЛ-ТА");
            int index = IndexMinElem(arr);
            Console.WriteLine(index);


            Console.WriteLine("\nНАЙТИ ПО ЗНАЧЕНИЮ");
            int index1 = FindElem(arr, 6);
            Console.WriteLine(index1);
        }
    }
}
