using System;

namespace exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1;
            float num2, num3;

            Console.WriteLine("leia o valor do produto");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("qual o acréscimo");
            num2 = float.Parse(Console.ReadLine());

            num3 = ((num1 / 100)* num2)+ num2;

            Console.WriteLine("Valor da mercadoria: " + num3);


        }
    }
}
