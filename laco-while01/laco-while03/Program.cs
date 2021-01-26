using System;

namespace laco_while03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
             * um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
             * 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
             * que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
             * mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
             * exemplo.
             */

            // Declaração de variáveis
            int marcador = 0, alcool = 0, gasolina = 0, diesel = 0;

            // Entrada de variáveis
            Console.WriteLine("*** Seja bem-vinde ***\n");
            while (marcador != 4)
            {
                Console.WriteLine("\nPor favor, informe qual combustível deseja abastacer: ");
                Console.WriteLine("[1] Álcool, [2] Gasolina, [3] Diesel, [4] Encerrar");
                marcador = int.Parse(Console.ReadLine());
                if (marcador == 1)
                {
                    alcool++;
                }
                else if (marcador == 2)
                {
                    gasolina++;
                }
                else if (marcador == 3)
                {
                    diesel++;
                }
                else if (marcador != 4)
                {
                    Console.WriteLine("Informe um número válido, conforme informado acima");
                }
            }

            Console.WriteLine("\nMuito Obrigado!");
            Console.WriteLine("\nO consumo total foi de: ");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
