using System;

namespace vetores02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
             * - todos os números pares
             * - a quantidade de números pares
             * 
             */

            // Declaração das variáveis
            int tamanhoVetor, contadorPares = 0;

            // Entrada do tamano do vetor, informado pelo usuário
            Console.WriteLine("Informe o tamanho do vetor: ");
            tamanhoVetor = int.Parse(Console.ReadLine());

            // Declaração e instanciação do vetor de número inteiros e do vetor auxiliar para recebimento dos números pelo usuário
            int[] vetorInteiros = new int[tamanhoVetor];
            string[] vetorAuxiliar = Console.ReadLine().Split(' ');


            // For para popular o vetor de inteiros, além de imprimir apenas os números pares
            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetorInteiros[i] = int.Parse(vetorAuxiliar[i]);
                if (vetorInteiros[i] % 2 == 0)
                {
                    Console.Write(vetorInteiros[i] + " ");
                    contadorPares++;
                }
            }

            // Saída com a quantidade de números pares informados pelo usuário
            Console.WriteLine($"\nA quantidade de números pares foi de {contadorPares}");
        }
    }
}
