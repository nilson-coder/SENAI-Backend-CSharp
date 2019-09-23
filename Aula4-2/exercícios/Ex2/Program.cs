using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Faça um algoritmo que leia os valores de dois vetores de 10 posições gere um terceiro
            //vetor de 20 posições que seja a união dos dois primeiros.
            
            string[] valo1 = new string[10];
            string[] valo2 = new string[10];
            string[] valo3 = new string[20];
            
            for(int i = 0; i <= 9; i++){
                Console.WriteLine("Digite o valor: ");
                valo1[i] = Console.ReadLine();
            }

            for(int i = 0; i <= 9; i++){
                Console.WriteLine("Digite o valor: ");
                valo2[i] = Console.ReadLine();
            }

            for(int i = 0; i <= 9; i++){
                valo3[i] = valo1[i];
                valo3[i+10] = valo2[i];

            }

            for(int i = 0; i <= 20; i++){
                Console.WriteLine(valo3[i]);
            }

        }
    }
}
