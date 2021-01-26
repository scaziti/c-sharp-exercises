using System;

namespace matrizes02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ler um número N e depois uma matriz quadrada NxN com números inteiros. Depois, mostrar na tela a soma dos
             * elementos de cada linha da matriz.
             */

            int tamanhoMatriz;

            Console.WriteLine("Informe o tamanho da matriz quadrada: ");
            tamanhoMatriz = int.Parse(Console.ReadLine());

            int[,] matrizQuadrada = new int[tamanhoMatriz, tamanhoMatriz];

            int[] vetorSoma = new int[tamanhoMatriz];

            for (int i = 0; i < tamanhoMatriz; i++)
            {
                string[] vetorAuxiliar = Console.ReadLine().Split(' ');
                for (int j = 0; j < tamanhoMatriz; j++)
                {
                    matrizQuadrada[i, j] = int.Parse(vetorAuxiliar[j]);
                    vetorSoma[i] += matrizQuadrada[i, j];
                }
            }

            for (int i = 0; i < tamanhoMatriz; i++)
            {
                Console.WriteLine($"\n{vetorSoma[i]}");
            }
        }
    }
}
