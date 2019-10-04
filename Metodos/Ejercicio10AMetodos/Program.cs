using System;

namespace Ejercicio10AMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un string");
            string frase = Console.ReadLine();
            CuentaPalabras(frase);
        }
        public static void CuentaPalabras(string frase)
        {
            //string[] fraseSeparad;
            //fraseSeparad = frase.Split(" ");
            //int numeroPalabras = fraseSeparad.Length;
            //Console.WriteLine("El numero de palabras son {0}", numeroPalabras);
            int cuentaPalabras = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (i == 0)
                {
                    cuentaPalabras++;
                }
                //string caracter = frase[i].ToString();
                string caracter = frase.Substring(i, 1);
                if (caracter == " " && frase.Substring(i + 1, 1) != " ")
                {
                    cuentaPalabras++;
                }
            }
            Console.WriteLine("El numero de palabras son {0}", cuentaPalabras);
        }
 






    }
