using System;

namespace matrizes04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ler um inteiro N e uma matriz quadrada de ordem N. 
             * Mostrar a soma dos elementos acima da diagonal principal.
             */

            int tamanhoMatriz, somaDiagonal = 0, somaAcimaDiagonal = 0;

            Console.WriteLine("Informe o tamanho da matriz: ");
            tamanhoMatriz = int.Parse(Console.ReadLine());

            int[,] matrizQuadrada = new int[tamanhoMatriz, tamanhoMatriz];

            for (int i = 0; i < tamanhoMatriz; i++)
            {
                Console.WriteLine($"Informe os valores da linha {i + 1}: ");
                string[] vetorAuxiliar = Console.ReadLine().Split(' ');
                for (int j = 0; j < tamanhoMatriz; j++)
                {
                    matrizQuadrada[i, j] = int.Parse(vetorAuxiliar[j]);
                }
            }

            for (int i = 0; i < tamanhoMatriz; i++)
            {
                somaDiagonal += matrizQuadrada[i, i];
            }

            for (int i = 0; i < tamanhoMatriz; i++)
            {
                for (int j = i + 1; j < tamanhoMatriz; j++)
                {
                    somaAcimaDiagonal += matrizQuadrada[i, j];
                }
            }

            Console.WriteLine($"\nA soma da diagonal principal foi de: {somaDiagonal}");
            Console.WriteLine($"\nA soma dos números acima da diagonal é de: {somaAcimaDiagonal}");

        }
    }
}
