using System;

namespace exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1;
            float media;

            Console.WriteLine("Digite o numero");
            num1 = int.Parse(Console.ReadLine());

            media = num1 * 3;
            Console.WriteLine("numero é: " + media);


        }
    }
}
