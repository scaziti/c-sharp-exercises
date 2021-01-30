using System;
using System.Globalization;

namespace object_oriented_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apenas crie esse programa sem utilizar conceito de programas O.O.

            double somaX = 0.00, somaY = 0.00, valorDeX, valorDeY, areaTrianguloX = 0.00, areaTrianguloY = 0.00, maiorArea = 0.00;

            double[] trianguloX = new double[3];
            double[] trianguloY = new double[3];


            for (int i = 0; i < trianguloX.Length; i++)
            {
                Console.Write($"\nInforme o {i + 1}º valor do triângulo X: ");
                trianguloX[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                somaX += trianguloX[i];
            }
            valorDeX = somaX / 2.0;

            PulaLinha();
            for (int i = 0; i < trianguloY.Length; i++)
            {
                Console.Write($"\nInforme o {i + 1}º valor do triângulo Y: ");
                trianguloY[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                somaY += trianguloY[i];
            }
            valorDeY = somaY / 2.0;

            // fórmula de Heron
            areaTrianguloX = Math.Sqrt((valorDeX * (valorDeX - trianguloX[0]) * (valorDeX - trianguloX[1]) * (valorDeX - trianguloX[2])));
            areaTrianguloY = Math.Sqrt((valorDeY * (valorDeY - trianguloY[0]) * (valorDeY - trianguloY[1]) * (valorDeY - trianguloY[2])));
            if (areaTrianguloX > areaTrianguloY)
            {
                maiorArea = areaTrianguloX;
            }
            else
            {
                maiorArea = areaTrianguloY;
            }
            PulaLinha();

            Console.WriteLine($"Área do triângulo X =  {areaTrianguloX:f4}");
            Console.WriteLine($"Área do triângulo Y = {areaTrianguloY:f4}");
            Console.WriteLine($"Maior área = {maiorArea:f2}");
        }

        static void PulaLinha()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}
