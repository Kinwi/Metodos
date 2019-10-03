using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string nombre = "Raul";
            SaludarNombre(nombre);
            string saludo = SaludarNombre2(nombre);
            Console.WriteLine(SaludarNombre2(nombre));
        }

        // Los metodos se declaran fuera del "Main

        public static void SaludarNombre(string nombre)
        {

            Console.WriteLine($"Hola {nombre}");

        }

        public static string SaludarNombre2(string nombre)
        {

            return $"Hola {nombre}";
        }

    }
}
