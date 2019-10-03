using System;

namespace Ejercicio4Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             4.Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos.
             En el programa principal, pide al usuario 2 números. Usa esos 2 números como parámetros de
             la función y
             después asigna el valor que devuelve la función a una tercera variable en el programa. 
             Finalmente, muestra el valor de la variable en la pantalla.

             * 
             */

            Console.WriteLine("Inserte dos numeros");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int suma = sumarNumeros(numero1,numero2);
            Console.WriteLine(suma);

        }

        public static int sumarNumeros(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            return suma;
        }
    }
}
