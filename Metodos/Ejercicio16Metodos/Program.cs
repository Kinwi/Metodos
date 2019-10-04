using System;

namespace Ejercicio16Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Crea una aplicación que nos cuente el número de cifras de un número entero
            positivo(hay que controlarlo) pedido por teclado.Crea un método que realice esta acción:
            pasando el número por parámetro, devolverá el número de cifras.
            */

            Console.WriteLine("Aplicacion control de numero de cifras entero positivo");
            Console.WriteLine("Introduzca un numero por teclado");
            string number =Console.ReadLine();
        }

        public static int CountPositiveNumbers(int number)
        {
            char numberChar = Convert.ToChar(number);

            if (numberChar.IsDigit )


            return numberOfNumbers;

        }

        
    }
}
