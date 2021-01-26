using System;
using System.Globalization;

namespace laco_for03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
             * de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
             * conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
             * peso 5.
             * 
             */

            // Declaração das variáveis
            int contador;
            double nota1 = 0.0, nota2 = 0.0, nota3 = 0.0, somaNotas = 0.0, mediaPonderada;

            // Entrada do número de casos que serão avaliados
            Console.WriteLine("Informe o número de vezes que deseja testar a média: \n");
            contador = int.Parse(Console.ReadLine());

            double[] vetorMedia = new double[contador];

            // utilização do laço, juntamente com um vetor auxiliar para que os valores sejam informados na mesma linha
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Agora informe a nota {i + 1}: ");
                string[] vetorAuxiliar = Console.ReadLine().Split(' ');
                nota1 = double.Parse(vetorAuxiliar[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(vetorAuxiliar[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(vetorAuxiliar[2], CultureInfo.InvariantCulture);

                somaNotas = (nota1 * 2.0) + (nota2 * 3.0) + (nota3 * 5.0);
                vetorMedia[i] = somaNotas / 10.0;
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"\nMédia: {vetorMedia[i]:F2}");
            }
        }
    }
}
