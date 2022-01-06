using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D vect1 = new Vector3D (5f, 4f, 1f);

            Console.WriteLine("Нестатический метод Show ");
            vect1.Show();

            Vector3D vect2 = new Vector3D(5f, 4f, 1f);
            Vector3D result = new Vector3D();

            //Cтатический метод stAdd
            result = Vector3D.stAdd(vect1, vect2);

            Console.WriteLine("\nНестатический метод Show ");
            result.Show();

            Console.WriteLine("\nCтатический метод stShow ");
            Vector3D.stShow(result);

            Vector3D result1 = new Vector3D();

            //Нестатический метод Add
            result1 = vect1.Add(vect2);

            Console.WriteLine("\nНестатический метод Show ");
            result1.Show();
        }

        
    }
}
