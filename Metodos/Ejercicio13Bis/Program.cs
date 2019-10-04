using System;

namespace Ejercicio13Bis
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 100;
            /*
                13 Crea una aplicación que nos calcule el área de un círculo, 
                cuadrado o triángulo. Pediremos de qué figura queremos calcular su área
                y según lo introducido pedirá los valores necesarios para calcular el área.
                Crea un método por cada figura para calcular cada área, este devolverá un número real.
                Muestra el resultado por pantalla
            */
            do
            {
                
                Console.WriteLine("Calculdor de Areas");
                Console.WriteLine("Introduzca 1 Area Circulo , 2 Area Cuadrado, 3 Area Triangulo");
                 caseSwitch = Convert.ToInt32(Console.ReadLine());

            
            switch (caseSwitch)
               
                {
                    case 1:

                        Console.WriteLine("Introduzca el radio del circulo");
                        double radio = Convert.ToInt32(Console.ReadLine());
                        double pi = 3.14159;
                        Console.WriteLine(CalcularAreaCirculo(pi, radio));

                        break;

                    case 2:
                        Console.WriteLine("Introduzca el lado del cuadrado");
                        int lado = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(CalcularAreaCuadrado(lado));
                        break;

                    case 3:
                        Console.WriteLine("Introduzca la base del triangulo");
                        int base1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduzca la altura del triangulo");
                        int altura = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(CalcularAreaTriangulo(base1, altura));
                        break;

                    default:
                        Console.WriteLine("Progrma finalizado.Muchas gracias por utilizar el programa de calculo de areas");
                        break;

                }

            } while (caseSwitch != 0);





        }


        public static double CalcularAreaCirculo(double Pi, double radio)
        {


            double areaCirculo = Pi * Math.Pow(radio, 2);

            return areaCirculo;

        }


        public static int CalcularAreaCuadrado(int lado)
        {

            int areaCuadrado = lado * lado;

            return areaCuadrado;
        }

        public static int CalcularAreaTriangulo(int base1, int altura)
        {

            int areaTriangulo = (base1 * altura) / 2;

            return areaTriangulo;
        }

    }
}
