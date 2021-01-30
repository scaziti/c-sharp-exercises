using System;

namespace funcoes01
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNum, segundoNum, terceiroNum, resultadoFinal;

            Console.WriteLine("Informe 3 números: ");
            primeiroNum = int.Parse(Console.ReadLine());
            segundoNum = int.Parse(Console.ReadLine());
            terceiroNum = int.Parse(Console.ReadLine());

            resultadoFinal = mostraMaiorNumero(primeiroNum, segundoNum, terceiroNum);

            Console.WriteLine($"O maior número digitado foi {resultadoFinal}");
        }

        static int mostraMaiorNumero(int numA, int numB, int numC)
        {
            int resultadoMaior = 0;
            if (numA > numB && numA > numC)
            {
                resultadoMaior = numA;
            }
            else if (numB > numA && numB > numC) 
            {
                resultadoMaior = numB;
            }
            else
            {
                resultadoMaior = numC;
            }
            return resultadoMaior;
        }
    }
}
