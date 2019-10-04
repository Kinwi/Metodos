using System;

namespace Ejercicio15Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una aplicación que nos calcule el factorial de un número pedido por teclado, 
                lo realizará mediante un método al que le pasamos el número como parámetro.
                Para calcular el factorial, se multiplica los números anteriores hasta llegar a uno.
                Por ejemplo, si introducimos un 5, realizará esta operación 5 * 4 * 3 * 2 * 1 = 120.
            */


            Console.WriteLine("Aplicacion para calcular factorial");
            Console.WriteLine();
            Console.WriteLine("Introduce un numero para factorizar");
            int number = Convert.ToInt32(Console.ReadLine());
            CalculateFactorialNumber(number);





        }


        public static void CalculateFactorialNumber(int number)
        {
            int factorial = 1;

            for (int i = number; i >0; i--)
            {

                Console.WriteLine(factorial *= i);

                
            }

            
        }

        
    }
}
