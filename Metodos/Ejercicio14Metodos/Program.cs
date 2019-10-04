using System;

namespace Ejercicio14Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crea una aplicación que nos genere una cantidad de números enteros aleatorios 
             * (preguntar cuántos quiere generar). Crea un método donde pasamos como parámetros
             * entre qué números queremos que los genere (preguntamos al usuario los límites). 
             * Muestra estos números por pantalla.
             */

            Console.WriteLine("Aplicacion para generar numeros aleatorios");
            Console.WriteLine();
            Console.WriteLine("Introduca el limite por debajo de los numeros a generar");
            int limitDown = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Introduca el limite por arriba de los numeros a generar");
            int limitUp = Convert.ToInt32(Console.ReadLine());
            CalculateAleatoryNumbers(limitDown, limitUp);

        }

        public static void CalculateAleatoryNumbers(int limitDown, int limitUp)

        {
            Random r = new Random();
            Console.WriteLine("Introduzca cuantos numeros quiere generar");
            int numberOfNumbers = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i <numberOfNumbers; i++)
            {
                int aleatorio = r.Next(limitDown, limitUp);
                Console.WriteLine(aleatorio);
            }
            


        }

  
    }
}
