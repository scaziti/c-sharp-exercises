using System;

namespace vetores05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média aritmética somente
             * dos números pares lidos. 
             */

            // Declaração de variáveis
            int tamanhoVetor, somaPares = 0, contadorPares = 0;
            double mediaPares;

            // Entrada dos tamanho do vetor pelo usuário
            Console.WriteLine("Informe o tamanho do vetor desejado: ");
            tamanhoVetor = int.Parse(Console.ReadLine());

            // Declaração e instanciação do vetor de números inteiros
            int[] vetorInteiros = new int[tamanhoVetor];

            // Utilização de um vetor auxiliar para que o usuário digite os valores na mesma linha
            Console.WriteLine("\nAgora informe os números que deseja: ");
            string[] vetorAuxiliar = Console.ReadLine().Split(' ');

            // for para popular o vetor de inteiros e somar apenas os números pares
            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetorInteiros[i] = int.Parse(vetorAuxiliar[i]);
                if (vetorInteiros[i] % 2 == 0)
                {
                    somaPares += vetorInteiros[i];
                    contadorPares++;
                }
            }

            // Cálculo da média obtida apenas dos números pares
            mediaPares = somaPares / contadorPares;

            // Saída da média obtida pelo programa
            Console.WriteLine($"\nA média apenas dos números pares foi de {mediaPares:F2}");
        }
    }
}
