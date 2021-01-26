using System;
using System.Globalization;

namespace vetores04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos
             * elementos. Depois mostrar todos os elementos do vetor que estejam abaixo da média.
             * 
             */

            // Declaração das variáveis
            int tamanhoVetor;
            double somaVetor = 0.0, mediaVetor;

            // Entrada do tamanho do vetor, informado pelo usuário
            Console.WriteLine("Informe o tamanho do vetor desejado: ");
            tamanhoVetor = int.Parse(Console.ReadLine());

            // Declaração e instanciação do vetor de números reais
            double[] vetorNumReais = new double[tamanhoVetor];

            // utilização de um vetor auxiliar
            Console.WriteLine("Informe os valores que deseja para preencher o vetor: ");
            string[] vetorAuxiliar = Console.ReadLine().Split(' ');

            // Utilização do for para popular o vetor de números reais
            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetorNumReais[i] = double.Parse(vetorAuxiliar[i], CultureInfo.InvariantCulture);
                somaVetor += vetorNumReais[i];
            }

            // processamento da média obtida, após somar todos os valores do vetor
            mediaVetor = somaVetor / tamanhoVetor;

            // Saída para o usuário com a média calculada
            Console.WriteLine($"\nA média geral de todos os valores informados foi de {mediaVetor:F3}");

            // Saída dos valores abaixo da média (obtida acima)
            for (int i = 0; i < tamanhoVetor; i++)
            {
                if (vetorNumReais[i] < mediaVetor)
                {
                    Console.WriteLine(vetorNumReais[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
