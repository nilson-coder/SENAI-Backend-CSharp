using System;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] media = new double[10];

            for(int i = 0; i <= 9; i++){

                Console.Write("Digite a posições: ");
                media[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(media[10]);
            Console.WriteLine();


            for(int i = 0; i <= media.Length -1 ; i++){

                Console.WriteLine("Média :" + media[i]);

            
            }
        }
    }
}
