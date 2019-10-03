using System;

namespace Ejercicio3Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             3. Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos. 
              Asigna el valor de la llamada a la función en una variable en el programa 
              principal y muestra el resultado en la pantalla.
             * 
             */

            
            int suma =sumarNumeros(5,7);
            Console.WriteLine(suma);
        }

        public static int sumarNumeros(int numero1, int numero2) {

            int suma = numero1 + numero2;

            return suma;
        }


    }
}
