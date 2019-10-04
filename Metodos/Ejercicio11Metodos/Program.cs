using System;

namespace Ejercicio11Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escribe un método que reciba un array de ints y
             * lo muestre en pantalla desde la primera posición hasta la última.
             * Después escribe otra función que reciba un array de ints y 
             * lo muestre en pantalla desde la última posición a la primera. 
             * Crea un array en el programa principal y pásalo a cada una de las funciones.

             * 
             */



            int[] arrayNumeros = { 25, 84, 14, 68, 5, 6, 13, 125, 14, 10 };

            Console.WriteLine("Array mostrar desde la primera posicion a la ultima");
            ArrayIntsPrimeraUltima(arrayNumeros);

            Console.WriteLine("Array Ordenado desde valor alto a valor bajo");
            ArrayIntsUltimaPrimera(arrayNumeros);


        }
        public static int[] ArrayIntsPrimeraUltima(int[] arrayNumeros)
        {
          

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                //arrayNumeros[i] = numeros;
                Console.WriteLine(arrayNumeros[i]);
            }
            return arrayNumeros;


        }

        public static int[] ArrayIntsUltimaPrimera(int[] arrayNumeros)
        {
            

            for (int i = arrayNumeros.Length -1; i >= 0; i--)
            {
               // arrayNumeros[i] = numeros;
                Console.WriteLine(arrayNumeros[i]);
            }
            return arrayNumeros;
        }
    }
 }  