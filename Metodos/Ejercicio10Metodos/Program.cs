using System;

namespace Ejercicio10Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            //Escribe un programa que dé la vuelta a un string pasado por parámetro y lo devuelva.


            Console.WriteLine("Escriba una palabra");
            palabra = Console.ReadLine();
            string mostrarPalabra = darVuelta(palabra);
            Console.WriteLine("La palabra es " + palabra + "y dada la vuelta " + mostrarPalabra);


        }




        public static string darVuelta(string palabra) { 

        string acumularPalabra ="";
        
            // Al ser substring si empezamos desde atras " int i = palabras.Length-1"
            // Este bucle funciona distinto va desde el ultimo hasta 0

            for (int i = palabra.Length-1; i >= 0; i--)
                
               
            {
                // Vas a la ultima posicion "i" y coges un caracter "1" -EL ULTIMO-
                char letra = Convert.ToChar(palabra.Substring(i,1));
            
                acumularPalabra = acumularPalabra + letra;

            }

                return acumularPalabra;
        }
    }
}
