using System;

namespace MetodoEjercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int año ;
            /*
             * Escribe una función a la que le pasamos un año y devuelve true si es bisiesto. 
             * En el programa principal, pídele al usuario un número y muestra en pantalla 
             * “El año … es bisiesto” o “El año … no es bisiesto” y sigue pidiendo números y 
             * diciendo si es o no bisiesto hasta que introduzca un 0.
             * 
             */


            do
            {
                Console.WriteLine("Introduce un año");
                año = Convert.ToInt32(Console.ReadLine());

                bool añoBisiesto = CompruebaAño(año);

                if (añoBisiesto == true)

                {
                    Console.WriteLine("El año " + año + " es bisiesto");
                }
                else
                {
                    Console.WriteLine("El año " + año + " no es bisiesto");
                }

            } while (año != 0);



        }

        public static bool CompruebaAño(int año) { 
        
            bool bisiesto = true;
            if (año % 4 == 0 && año % 100 != 0)
            {

                bisiesto = true;
            }
            else
            {
                bisiesto = false;

            }

            return bisiesto;
        }
    }  
}
