using System;

namespace Ejercicio6Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escribe una función a la que le damos dos números y que devuelva true si
             * el primer número es más grande que el segundo número y false en el caso contrario.
             * En el programa principal, pide dos números al usuario, y pasalos a la función. Muestra en pantalla 
             * “El primer número es más grande” o “El primer número no es más grande”.
             * 
             */

            Console.WriteLine("Introduce dos numeros");
            Console.WriteLine();
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            bool comparacion =compararNumeros(numero1, numero2);
            Console.WriteLine("El " + numero1 + " es mayor que el " + numero2 +"  " + comparacion);
        }

        public static bool compararNumeros(int numero1, int numero2)
        {
            bool respuesta = true;

            if (numero1 > numero2)
            {
                respuesta = true;
            }

            else

            {
                respuesta = false;
            }
            return respuesta;

        }
    }
}
