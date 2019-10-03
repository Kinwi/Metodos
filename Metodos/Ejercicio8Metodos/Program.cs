using System;

namespace Ejercicio8Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            /*
             * 8 Diseña un método EsPar() que reciba como parámetro un entero y devuelva si ese número es par o no.
             * Utilízalo en un programa que lea un número por teclado y determine si es par o no.
             * 
             * 
             */

            Console.WriteLine("Introduzca un numero para saber si es par o no");
            numero = Convert.ToInt32(Console.ReadLine());
            bool comprobarPar = esPar(numero);
            Console.WriteLine("El " + numero + " es Par ?" + " Respuesta :  " + comprobarPar);
        }

        public static bool esPar(int numero)
        {
            bool parImpar;

            if (numero % 2 == 0)

            {
                parImpar = true;
            }

            else
            {
                parImpar = false;
            }
            return parImpar;
        }
    }
}
