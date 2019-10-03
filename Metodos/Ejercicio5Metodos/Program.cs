using System;

namespace Ejercicio5Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.Escribe un programa que pida al usuario dos números.
            Usa esos 2 números en una función que divide el primero por el segundo y 
            devuelve el resultado.Muestra el resultado que devuelve la función en pantalla.
            Después vuelve a pedir los números y hacer todo otra vez hasta que el usuario introduzca un 0 como segundo número.
            */
            int numero1;
            int numero2;
            do
            {
                Console.WriteLine("Introduzca dos numeros para realizar division");
                Console.WriteLine("Introduca un 0 si desea salir de la aplicacion");


                numero1 = Convert.ToInt32(Console.ReadLine());
                numero2 = Convert.ToInt32(Console.ReadLine());

            } while (numero2 != 0);

            if (numero2 != 0)
                {
                double division = RealizarDivision(numero1, numero2);
                Console.WriteLine(division);
                 }


           

            
        }

        public static double RealizarDivision(double numero1, double numero2)
        {
            double division = numero1 / numero2;
            return division;

        }
    }
}
