using System;
using System.Globalization;

namespace laco_while02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
             * cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
             * menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
             */

            // Declaração das variáveis
            double coordenadaX, coordenadaY;

            // Entrada dos dados fornecidos pelo usuário
            Console.WriteLine("*** Seja bem-vinde *** ");
            Console.WriteLine("\nPor favor informe a coordenada X: ");
            coordenadaX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nPor favor informe a coordenada Y: ");
            coordenadaY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (coordenadaX != 0.0 && coordenadaY != 0.0)
            {
                if (coordenadaX > 0.0 && coordenadaY > 0.0)
                {
                    Console.WriteLine("\nQuadrante I");
                }
                else if (coordenadaX < 0.0 && coordenadaY > 0.0)
                {
                    Console.WriteLine("\nQuadrante II");
                }
                else if (coordenadaX < 0.0 && coordenadaY < 0.0)
                {
                    Console.WriteLine("\nQuadrante III");
                }
                else if (coordenadaX > 0.0 && coordenadaY < 0.0)
                {
                    Console.WriteLine("\nQuadrante IV");
                }

                Console.WriteLine("\nPor favor informe a coordenada X: ");
                coordenadaX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("\nPor favor informe a coordenada Y: ");
                coordenadaY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}
