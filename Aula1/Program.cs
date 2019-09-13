using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // somente declaramos, sem atribuir valor
            int num1;

            // declaramos atribuindo um valor
            int num2 = 5;

            // declaramos diversas variaveis do mesmo tipo
            int num3, num4, num5;

            // variavel do tipo decimal (real)
            float media;

            // variavel do tipo logico (booleana)
            bool resultado = false;

            // Variavel do tipo texto (caracteres)
            string nomeAluno;

            // Quebra linha
            Console.WriteLine();

            // escreve em uma linha quebrando-a
            Console.WriteLine("Bem vindos a nossa primeira aplicação!");

            // continua escrevendo na mesma linha
            Console.Write("Digite");
            Console.Write(" seu nome: ");

            // capturo o dado digitado pelo usuário e salvo na variável
            nomeAluno = Console.ReadLine();

            // Concatenação
            Console.WriteLine(nomeAluno + ", Agora digite sua Primeira nota:");
            
            // Converto o texto capturado para o tipo inteiro
            num3 = int.Parse(  Console.ReadLine()  );

            // Interpolação
            Console.WriteLine($"Sua primeira nota é {num3}");

            Console.WriteLine("Digite sua segunda nota :");
            num4 = int.Parse(  Console.ReadLine()  );

            Console.WriteLine("Digite sua terceira nota");
            num5 = int.Parse(  Console.ReadLine()  );

            media = (num3 + num4 + num5) / 3;

            Console.WriteLine("Sua média é: " + media);

            

        }
    }
}
