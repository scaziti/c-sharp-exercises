using System;

namespace laco_while01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
             * incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
             * impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
             */

            // Declaração da variável
            int senhaDigitada;

            // Entrada da senha pelo usuário
            Console.WriteLine("*** Seja Bem-Vinde ***\n");
            Console.WriteLine("Por favor informe a senha de 4 digítos: ");
            senhaDigitada = int.Parse(Console.ReadLine());

            // Processamento e saída para o usuário, caso a senha esteja inválida 
            while (senhaDigitada != 2002)
            {
                Console.WriteLine("Senha inválida, por favor informe a correta\n");
                senhaDigitada = int.Parse(Console.ReadLine());
            }

            // Saída para o usuário informando a senha válida
            Console.WriteLine("\nAcesso Permitido");
        }
    }
}
