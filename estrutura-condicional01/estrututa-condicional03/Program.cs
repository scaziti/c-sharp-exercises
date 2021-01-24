using System;

namespace estrututa_condicional03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
             * Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
             * ordem crescente ou decrescente.
             * 
             */

            // Declaração das variáveis
            int numA, numB;

            // Entrada dos valores utilizando um vetor auxiliar para que o usuário digite os valores na mesma linha
            Console.WriteLine("Informe os números que deseja na mesma linha: ");
            string[] vetorAuxiliar = Console.ReadLine().Split(' ');
            numA = int.Parse(vetorAuxiliar[0]);
            numB = int.Parse(vetorAuxiliar[1]);

            // Processamento e saída com o resultado para o usuário
            if (numA % numB == 0 || numB % numA == 0)
            {
                Console.WriteLine("\nOs números são múltiplos entre si");
            }
            else
            {
                Console.WriteLine("\nOs números não são múltiplos entre si");
            }

            // Aguardar o usuário digitar para encerrar o programa
            Console.ReadLine();
        }
    }
}
