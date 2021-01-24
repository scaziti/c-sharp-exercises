using System;

namespace estrutura_condicional01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
             * 
             */

            // Declaração de variável
            int num;

            // Entrada de valores pelo usuário
            Console.WriteLine("Informe um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            // Processamento e Saída
            if (num < 0)
            {
                Console.WriteLine("O número informado é negativo");
            }
            else
            {
                Console.WriteLine("O número informado é positivo");
            }
        }
    }
}
