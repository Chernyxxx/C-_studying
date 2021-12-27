using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Triangle_in_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; i<10; i++ )
            {

                // Вложенный цикл for имеет 2 условия выхода

                for (int j=0; j<10 && j<(10-i); j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
