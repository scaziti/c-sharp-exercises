using System;

namespace matrizes03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar qual o maior elemento de cada linha. 
             * Suponha não haver empates.
             */

            int tamanhoMatriz;

            Console.WriteLine("Informe o tamanho da matriz: ");
            tamanhoMatriz = int.Parse(Console.ReadLine());

            int[,] matrizQuadrada = new int[tamanhoMatriz, tamanhoMatriz];
            int[] vetorMaiorElemento = new int[tamanhoMatriz];

            for (int i = 0; i < tamanhoMatriz; i++)
            {
                Console.WriteLine($"Informe a linha {i + 1}: ");
                string[] vetorAuxiliar = Console.ReadLine().Split(' ');
                for (int j = 0; j < tamanhoMatriz; j++)
                {
                    matrizQuadrada[i, j] = int.Parse(vetorAuxiliar[j]);

                    if (matrizQuadrada[i, j] > vetorMaiorElemento[i])
                    {
                        vetorMaiorElemento[i] = matrizQuadrada[i, j];
                    }
                }
            }

            for (int i = 0; i < tamanhoMatriz; i++)
            {
                Console.WriteLine("\n" + vetorMaiorElemento[i]);
            }
        }
    }
}
