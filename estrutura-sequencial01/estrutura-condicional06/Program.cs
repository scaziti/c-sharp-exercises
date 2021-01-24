using System;
using System.Globalization;

namespace estrutura_condicional06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
             * mostre:
             * a) a área do triângulo retângulo que tem A por base e C por altura.
             * b) a área do círculo de raio C. (pi = 3.14159)
             * c) a área do trapézio que tem A e B por bases e C por altura.
             * d) a área do quadrado que tem lado B.
             * e) a área do retângulo que tem lados A e B.
             */

            // Declaração de variáveis
            double numA, numB, numC, areaTriang, areaCirc, areaTrap, areaQuad, areaRetan;

            // Entrada dos valores pelo usuários, utilizando um vetor auxiliar
            Console.WriteLine("Informe os valores das posições: ");
            string[] vetorAuxiliar = Console.ReadLine().Split(' ');
            numA = double.Parse(vetorAuxiliar[0], CultureInfo.InvariantCulture);
            numB = double.Parse(vetorAuxiliar[1], CultureInfo.InvariantCulture);
            numC = double.Parse(vetorAuxiliar[2], CultureInfo.InvariantCulture);

            // processamento dos valores
            areaTriang = (numA * numC) / 2;
            areaCirc = 3.14159 * Math.Pow(numC, 2);
            areaTrap = (numA + numB) * numC / 2;
            areaQuad = Math.Pow(numB, 2);
            areaRetan = (numA * numB);

            // Saída dos dados
            Console.WriteLine($"\nA área do triângulo: {areaTriang:F2}");
            Console.WriteLine($"A área do círculo: {areaCirc:F2}");
            Console.WriteLine($"A área do trapézio: {areaTrap:F2}");
            Console.WriteLine($"A área do quadrado: {areaQuad:F2}");
            Console.WriteLine($"A área do retângulo: {areaRetan:F2}");
        }
    }
}
