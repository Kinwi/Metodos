using System;

namespace Ejercicio1Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              1.Escribe una función que escriba “Hola” 3 veces. Llámala desde el programa principal.

             * 
             */

            Saludo();

        }

        public static void Saludo() {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hola");

            }

        }
    }
}
