﻿using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia os valores de dois vetores de 10 posições gere um terceiro
            //vetor que seja soma dos dois primeiros.

            int[] num1 = new int[10];
            int[] num2 = new int[10];
            int[] num3 = new int[10];

            for(int i = 0; i <= 9; i++){
                Console.Write("Digite um número: ");
                num1[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <= 9; i++){
                Console.Write("Digite um número: ");
                num2[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <= 9; i++){                
                num3[i] = num1[i] + num2[i];
            }

            for(int i = 0; i <= 9; i++){
                Console.WriteLine("V3 :" + num3[i] );
            }
        }
    }
}
