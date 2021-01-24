using System;
using System.Globalization;

namespace estrutura_sequencial04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
             * hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
             * decimais.
             */

            // Declaração das variáveis
            int numFuncionario;
            double horasTrabalhadas, valorPorHora, salarioFinal;

            // Entrada dos dados pelo usuário
            Console.WriteLine("Informe o código do funcionário: ");
            numFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora informe a quantidade de horas trabalhadas no mês: ");
            horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe quanto este funcionário recebe por horas trabalhadas: ");
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento do salário final que o funcionário receberá
            salarioFinal = valorPorHora * horasTrabalhadas;

            // Saída com o resultado do salário final
            Console.WriteLine($"O salário final do funcionário nº {numFuncionario} será de R$ {salarioFinal:F2}");
        }
    }
}
