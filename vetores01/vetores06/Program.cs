using System;

namespace vetores06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois, mostrar na tela o nome
             * da pessoa mais velha.
             */

            // Declaração das variáveis
            int tamanhoVetores, maisVelho = 0;
            string nomeMaisVelho = " ";

            // Entrada do tamanho dos vetores
            Console.WriteLine("Informe a quantidade de valores que deseja preencher: ");
            tamanhoVetores = int.Parse(Console.ReadLine());

            // Declaração e instanciação dos vetores: nome e idade
            string[] vetorNomes = new string[tamanhoVetores];
            int[] vetorIdades = new int[tamanhoVetores];

            Console.WriteLine("\nAgora informe os nomes e idades: ");
            // Utilização do for para popular vetores, além de um vetor auxiliar
            for (int i = 0; i < tamanhoVetores; i++)
            {
                string[] vetorAuxiliar = Console.ReadLine().Split(' ');
                vetorNomes[i] = vetorAuxiliar[0];
                vetorIdades[i] = int.Parse(vetorAuxiliar[1]);
                if (vetorIdades[i] > maisVelho)
                {
                    maisVelho = vetorIdades[i];
                    nomeMaisVelho = vetorNomes[i];
                }
            }

            // Saída para o usuário informando a pessoa mais velha e sua respectiva idade
            Console.WriteLine($"\nA pessoa informada mais velha foi {nomeMaisVelho} com {maisVelho} anos");
        }
    }
}
