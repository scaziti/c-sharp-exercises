using System;

namespace estrutura_sequencial03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
             * de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
             * 
             */

            // Declaração das variáveis utilizadas no programa
            int numA, numB, numC, numD, diferenca;

            // Entrada dos quatro valores, informados pelo usuário
            Console.WriteLine("Informe o N1: ");
            numA = int.Parse(Console.ReadLine());   
            Console.WriteLine("Informe o N2: ");
            numB = int.Parse(Console.ReadLine());   
            Console.WriteLine("Informe o N3: ");
            numC = int.Parse(Console.ReadLine());   
            Console.WriteLine("Informe o N4: ");
            numD = int.Parse(Console.ReadLine());

            // Processamento do cálculo para obtermos a diferença
            diferenca = (numA * numB - numC * numD);

            // Saída dos valores calculados
            Console.WriteLine($"\nDiferença dos valores digitados: {diferenca}");

            // Aguardar usuário encerrar programa
            Console.ReadLine();
        }
    }
}
