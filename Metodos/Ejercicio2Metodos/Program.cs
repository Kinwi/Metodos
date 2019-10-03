using System;

namespace Ejercicio2Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              2. Escribe una función que escriba “Hola” tantas veces como el número que le pasamos de parámetro.
              
              Llámala desde el programa principal dos veces, primero con 5 y después con 3.
             * 
             */

            imprimirNumero(3);
            imprimirNumero(5);



        }

        public static void imprimirNumero(int numero)
        {
            for (int i = 0; i < numero; i++) {

                Console.WriteLine("Hola");

            }

            
           
        }
    }
}
