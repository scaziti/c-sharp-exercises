using System;
using System.Globalization;

namespace vetores01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
             * do vetor (supor não haver empates). Mostrar também a posição do maior elemento.
             * 
             */

            // Declaração de variáveis
            int tamanhoVetor;
            double maiorNumero = 0, posicaoMaiorNumero = 0;

            // Entrada dos dados pelo usuário
            Console.WriteLine("Informe a quantidade de números que serão armazenados: \n");
            tamanhoVetor = int.Parse(Console.ReadLine());

            // Declaração e instanciação do vetor de inteiros e do vetor auxiliar
            double[] vetorInteiros = new double[tamanhoVetor];
            Console.WriteLine("Digite os números que deseja na mesma linha, dividindo-os por um espaço: ");
            string[] vetorAuxiliar = Console.ReadLine().Split(' '); ;

            // Entrada dos valores e processamentos dos mesmos
            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetorInteiros[i] = double.Parse(vetorAuxiliar[i], CultureInfo.InvariantCulture);

                if (vetorInteiros[i] > maiorNumero)
                {
                    maiorNumero = vetorInteiros[i];
                    posicaoMaiorNumero = i;
                }
            }

            // Saída dos valores informando o maior número digitado, assim como a posição do mesmo no vetor
            Console.WriteLine($"\nO maior número informado foi o {maiorNumero:F1} estando no vetor[{posicaoMaiorNumero}]");
        }
    }
}
