using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Dados dois vetores, A e B com 15 palavras, construa um terceiro vetor com os dados
            //dos vetores anteriores

            string[] num1 = new string[15];
            string[] num2 = new string[15];
            string[] num3 = new string[30];


            for(int i = 0; i <=14; i++){
                Console.Write("Digite uma palavra: ");
                num1[i] = Console.ReadLine();
            }

            
            for(int i = 0; i <=14; i++){
                Console.Write("Digite uma palavra: ");
                num2[i] = Console.ReadLine();
            }

            
            for(int i = 0; i <=14; i++){                
                num3[i] = num1[i];
            }

            
            for(int i = 0; i <=14; i++){
                num3[i+15] = num2[i];
            }

            for(int i = 0; i <=29; i++){
                Console.WriteLine("V3: "+ num3[i]);
            }
        }
    }
}
