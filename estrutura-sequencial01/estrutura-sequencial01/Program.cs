using System;

namespace estrutura_sequencial01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
             * mensagem explicativa, conforme exemplos.
             */

            // Declarando variáveis
            int numA, numB, soma;

            // Entrada dos valores pelo usuário
            Console.WriteLine("Informe o N1: ");
            numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe N2: ");
            numB = int.Parse(Console.ReadLine());

            // Processamento dos valores digitados, obtendo a soma
            soma = numA + numB;

            // Saída do resultado da soma entre os dois valores digitados pelo usuário
            Console.WriteLine("Soma = " + soma);

            // Esperar o usuário digitar para encerrar o programa
            Console.ReadLine();
        }
    }
}
