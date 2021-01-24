using System;

namespace estrutura_condicional05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
             * de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
             * ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
             * Se o ponto estiver na origem, escreva a mensagem “Origem”.
             * Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
             * situação.
             */

            // Declaração de variáveis
            double numX, numY;

            // Entrada de valores pelo usuário, utilizando um vetor auxiliar para que sejam digitados na mesma linha
            Console.WriteLine("Informe os eixos que deseja, informando-os na mesma linha, separados por um espaço: ");
            string[] vetorAuxiliar = Console.ReadLine().Split(' ');
            numX = double.Parse(vetorAuxiliar[0]);
            numY = double.Parse(vetorAuxiliar[1]);
             
            // Processamento e saída
            if (numX > 0 && numY > 0)
            {
                Console.WriteLine("Primeiro Quadrante");
            }
            else if (numX < 0 && numY > 0)
            {
                Console.WriteLine("Segundo Quadrante");
            }
            else if (numX < 0 && numY < 0)
            {
                Console.WriteLine("Terceiro Quadrante");
            }
            else if (numX > 0 && numY < 0)
            {
                Console.WriteLine("Quarto Quadrante");
            }
            else if (numX == 0 && numY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (numX == 0 && numY > 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (numX > 0 && numY == 0)
            {
                Console.WriteLine("Eixo Y");
            }

        }
    }
}
