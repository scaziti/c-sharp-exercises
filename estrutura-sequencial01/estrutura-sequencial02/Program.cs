using System;
using System.Globalization;

namespace estrutura_sequencial02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
             * casas decimais conforme exemplos.
             * Fórmula da área: area = π . raio2
             * Considere o valor de π = 3.14159
             * 
             */

            // Declaração da variável que receberá o valor do raio
            double raio, area;

            // Entrada do raio informado pelo usuário
            Console.WriteLine("Informe o valor do Raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento da área do círculo, utilizando o valor do Raio informado pelo usuário
            area = 3.14159 * Math.Pow(raio, 2);

            // Saída para o usuário com o resultado da área Calculada
            Console.WriteLine("A área total do círculo será de: " + area.ToString("F2", CultureInfo.InvariantCulture));

            // Aguardando usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}
