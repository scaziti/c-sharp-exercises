using System;

namespace matrizes01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo. 
             * Em seguida, mostrar na tela somente os números negativos da matriz.
             */

            int linhaM, colunaN;

            Console.WriteLine("Informe o valor do M e do N: ");
            string[] vetorAuxiliar = Console.ReadLine().Split(' ');
            linhaM = int.Parse(vetorAuxiliar[0]);
            colunaN = int.Parse(vetorAuxiliar[1]);

            int[,] matrizInteiros = new int[linhaM, colunaN]; // Declaração e Instanciação da matriz de nº inteiros 

            for (int i = 0; i < linhaM; i++)
            {
                vetorAuxiliar = Console.ReadLine().Split(' ');
                for (int j = 0; j <  colunaN; j++)
                {
                    matrizInteiros[i, j] = int.Parse(vetorAuxiliar[j]);
                }
            }

            Console.WriteLine("Valores Negativos: ");
            for (int i = 0; i < linhaM; i++)
            {
                for (int j = 0; j < colunaN; j++)
                {
                    if (matrizInteiros[i, j] < 0)
                    {
                        Console.WriteLine(matrizInteiros[i, j]);
                    }
                    
                }
            }
        }
    }
}
