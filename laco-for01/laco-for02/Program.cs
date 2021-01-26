using System;

namespace laco_for02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
             * Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
             * essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
             * 
             */

            // Declaração de variáveis
            int contador, numInformado = 0, foraIntervalo = 0, dentroIntervalo = 0;

            // Entrada dos valores pelo usuário
            Console.WriteLine("Informe a quantidade de valores que deseja preencher: ");
            contador = int.Parse(Console.ReadLine());

            // Processamento dos números informados, utilizando contadores para obter os que estão dentro ou fora
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("\nInforme um número: ");
                numInformado = int.Parse(Console.ReadLine());
                if (numInformado >= 10 && numInformado <= 20)
                {
                    dentroIntervalo++;
                }
                else
                {
                    foraIntervalo++;
                }

            }

            Console.WriteLine($"\nIn: {dentroIntervalo}");
            Console.WriteLine($"\nOut: {foraIntervalo}");
        }
    }
}
