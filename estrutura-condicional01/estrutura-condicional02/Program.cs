using System;

namespace estrutura_condicional02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
             * 
             */

            // Declaração da variável
            int num;

            // Entrada do número pelo usuário
            Console.WriteLine("Informe um número: ");
            num = int.Parse(Console.ReadLine());

            // Processamento
            if (num % 2 == 0)
            {
                Console.WriteLine("\nNúmero informado é PAR");
            }
            else
            {
                Console.WriteLine("\nNúmero informado é ÍMPAR");
            }

            // Esperar o usuário clicar para encerrar
            Console.ReadLine();
        }
    }
}
