using System;

namespace Ejercicio9Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;


            // 9.Escribe un programa que cuente las vocales de un string pasado por parámetro.

            Console.WriteLine("Escriba una palabra");
            palabra = Console.ReadLine().ToLower();

            int contarVocales = ContarVocales(palabra);
            Console.WriteLine("La palabra " + palabra + " tiene " + contarVocales + "vocales");

        }


        public static int ContarVocales(string palabra)
        { 

         int contadorVocales = 0;
            for(int i = 0; i<palabra.Length; i++)
            {
                char vocal = Convert.ToChar(palabra.Substring(i, 1));
                if((vocal == 'a') || (vocal == 'e') || (vocal == 'i') || (vocal == 'o') || (vocal == 'u'))
                {
                    contadorVocales++;
                }
}
            return contadorVocales;
        }


    }
}
