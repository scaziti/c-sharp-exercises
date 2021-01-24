using System;
using System.Globalization;

namespace estrutura_condicional04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
             * seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
             * nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
             * 
             */

            // Declaração de variável
            double num;

            // Entrada do valor informado pelo usuário
            Console.WriteLine("Informe um número qualquer [0 a 100]: ");
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num >= 0.00 && num <= 25.00)
            {
                Console.WriteLine("[0, 25]");
            }
            else if (num >= 25.01 && num <= 50.00)
            {
                Console.WriteLine("[25, 50]");
            }
            else if (num >= 50.01 && num <= 75.00) 
            {
                Console.WriteLine("[50, 75]");
            }
            else if (num >= 75.01 && num <= 100.00)
            {
                Console.WriteLine("[75, 100]");
            }
            else
            {
                Console.WriteLine("Valor fora do intervalo!");
            }

            // Aguardar usuário digitar para encerrar
            Console.ReadLine();

        }
    }
}
