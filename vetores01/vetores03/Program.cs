using System;

namespace vetores03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde
             * cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima o vetor C gerado.
             * 
             */

            // Declaração das variáveis
            int tamanhoVetores;

            // Entrada dos dados pelo usuário
            Console.WriteLine("Informe o tamanho dos vetores que deseja: ");
            tamanhoVetores = int.Parse(Console.ReadLine());

            // Declaração e instanciação dos vetores de inteiros
            int[] vetorInteirosA = new int[tamanhoVetores];
            int[] vetorInteirosB = new int[tamanhoVetores];
            int[] vetorInteirosC = new int[tamanhoVetores];

            // Entrada dos valores pelo usuário, para preenchimento do vetorA, utilizando um vetor auxiliar
            Console.WriteLine("\nInforme os valores do vetor A: ");
            string[] vetorAuxiliar = Console.ReadLine().Split(' ');

            // Utilização do for e vetor auxiliar para popular vetore de inteiros A com as informações preenchidas pelo usuário
            for (int i = 0; i < tamanhoVetores; i++)
            {
                vetorInteirosA[i] = int.Parse(vetorAuxiliar[i]);
            }

            // Entrada dos valores pelo usuário, para preenchimento do vetorB, utilizando um vetor auxiliar
            Console.WriteLine("\nInforme os valores do vetor B: ");
            vetorAuxiliar = Console.ReadLine().Split(' ');

            // Utilização do for e vetor auxiliar para popular vetore de inteiros B com as informações preenchidas pelo usuário
            for (int i = 0; i < tamanhoVetores; i++)
            {
                vetorInteirosB[i] = int.Parse(vetorAuxiliar[i]);
            }
            Console.WriteLine();

            // Utilização do for para percorrer os vetores A e B, somando-os e armazenando os resultados no vetor C. Depois exibindo
            for (int i = 0; i < tamanhoVetores; i++)
            {
                vetorInteirosC[i] = vetorInteirosA[i] + vetorInteirosB[i];
                Console.Write(vetorInteirosC[i] + " ");
            }
        }
    }
}
