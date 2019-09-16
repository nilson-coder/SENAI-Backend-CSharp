using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos as notas que utilizaremos
            double nota1, nota2, nota3, media;

            // capturamos a 1° nota
            Console.Write("Digite sua primeira nota: ");
            nota1 = double.Parse( Console.ReadLine() );

            // capturamos a 2° nota
            Console.Write("Digite sua sugunda nota: ");
            nota2 = double.Parse( Console.ReadLine() );

            // capturamos a 3° nota
            Console.Write("Digite sua terceira nota: ");
            nota3 = double.Parse( Console.ReadLine() );

            // calculamos a media das notas
            media = (nota1 + nota2 + nota3) / 3;
            
            // verificamos se a meida do aluno e maior o igual a 6
            if(media >= 6){

                Console.WriteLine($"Média: {media} Aluno aprovado");

            } else{

                Console.WriteLine($"Média: {media} Aluno reprovado");

            }


        }
    }
}
