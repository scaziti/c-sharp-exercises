using System;

namespace laco_for01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
             * X, se for o caso.
             * 
             */

            // Declaração de variável
            int numDigitado;

            // Entrada do número pelo usuário
            Console.WriteLine("*** Seja Bem-Vinde ***\n");
            Console.WriteLine("Informe um número inteiro: ");
            numDigitado = int.Parse(Console.ReadLine());

            // Processamento do número digitado, depois exibindo todos os números ímpares para o usuário
            for (int i = 0; i <= numDigitado; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
