using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {

          
            /*
             * 13Escriba una función que reciba un array y un valor booleano. 
             * Si el booleano es true, mostrar el array de modo ascendente, 
             * si es false, mostrarlo de modo descendente. En el programa principal, 
             * crear un array y hacer que la función lo muestre primero en modo ascendente
             * y después en modo descendente.

             * 
             */

            int[] arrayNumbers = { 20, 40, 5, 7, 256, 3, 24, 12, 1254 };
            Console.WriteLine("Imprimir array en orden ascendente");
            Console.WriteLine();
            ArrayUpDown(true, arrayNumbers);
            Console.WriteLine();
            Console.WriteLine("Imprimir array en orden descendente");
            ArrayUpDown(false, arrayNumbers);
           

        }

        public static void ArrayUpDown(bool answer1, int[] arrayNumbers)
        {

            if (answer1 == true)
            {
                Array.Sort(arrayNumbers);
                for (int i = 0; i < arrayNumbers.Length; i++)
                {

                    Console.WriteLine(arrayNumbers[i]);
                }

            }

            else

            {
                    Array.Reverse(arrayNumbers);

                    for (int i = 0; i < arrayNumbers.Length; i++)
                    {

                        Console.WriteLine(arrayNumbers[i]);

                    }

             

            }

        }
        
    }
}
