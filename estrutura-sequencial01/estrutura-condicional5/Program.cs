using System;
using System.Globalization;

namespace estrutura_condicional5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
             * código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
             * 
             */

            // Declaração das variáveis
            int codPeca1, codPeca2, quantidadePeca1, quantidadePeca2;
            double valorPeca1, valorPeca2, valorTotal;

            // Entrada dos dados do usuário, utilizando um vetor auxiliar, para que possa ser digitado na mesma linha
            Console.WriteLine("Informe na mesma linha o código do produto, quantidade e valor unitário: ");
            string[] vetorAuxiliar = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(vetorAuxiliar[0]);
            quantidadePeca1 = int.Parse(vetorAuxiliar[1]);
            valorPeca1 = double.Parse(vetorAuxiliar[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Agora informe na mesma linha o código do produto, quantidade e valor unitário: ");
            vetorAuxiliar = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(vetorAuxiliar[0]);
            quantidadePeca2 = int.Parse(vetorAuxiliar[1]);
            valorPeca2 = double.Parse(vetorAuxiliar[2], CultureInfo.InvariantCulture);

            // Processamento os valores finais, de acordo com a quantidade e valor informados pelos usuário
            valorTotal = (quantidadePeca1 * valorPeca1) + (quantidadePeca2 * valorPeca2);

            // Saída com o valor final da compra do usuário
            Console.WriteLine($"\nO valor final da sua compra será de R$ {valorTotal:F2}");
        }
    }
}
