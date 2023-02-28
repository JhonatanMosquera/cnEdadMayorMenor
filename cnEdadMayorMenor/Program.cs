using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadMayorOmenor
{
    /// <summary>
    /// Nombre: Jhonatan Stiven Mosquera Moreno
    /// fecha: 24/02/2023
    /// descripcion: Identificar EDAD
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la primer edad ");
            int edad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda edad");
            int edad2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera edad ");
            int edad3 = Convert.ToInt32(Console.ReadLine());
            ComprobarEdad(edad1, edad2, edad3);
            ComprobadorMenorEdad(edad1, edad2, edad3);
            Console.ReadKey();

        }


        public static void ComprobarEdad(double edad1, double edad2, double edad3)
        {

            if (edad1 > edad2 && edad1 > edad3)
            {

                Console.WriteLine("La edad mayor es " + edad1);

            }
            else if (edad2 > edad1 && edad2 > edad3)
            {

                Console.WriteLine("la mayor edad es " + edad2);

            }
            else if (edad3 > edad1 && edad3 > edad2)
            {
                Console.WriteLine("la mayor edad es " + edad3);
            }
            else
            {
                Console.WriteLine("hay 2 edades iguales");
            }

        }

        static void ComprobadorMenorEdad(int edad1, int edad2, int edad3)
        {


            if (edad1 < edad2 && edad1 < edad3)
            {

                Console.WriteLine("La edad menor es " + edad1);

            }
            else if (edad2 < edad1 && edad2 < edad3)
            {

                Console.WriteLine("la edad menor es " + edad2);

            }
            else if (edad3 < edad1 && edad3 < edad2)
            {
                Console.WriteLine("la menor edad  es " + edad3);
            }
            else
            {
                Console.WriteLine("hay 2 edades iguales");
            }
        }




    }
}

