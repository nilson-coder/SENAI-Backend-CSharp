using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("O maior número é: " + Maior());

        }

        static double Maior(){

            int maior = 0;
            string sair = "";
            int numeros = 0;
            
            while(sair != "sim"){
                try{
                Console.Write("Digite um número: ");
                numeros = int.Parse(Console.ReadLine());

                for(int i = 0; i <= numeros.ToString().Length; i++){
                
                if(i == 0){
                    maior = numeros;
                }

                if(numeros > maior){
                    maior = numeros;
                }
                }
                Console.Write("Deseja sair ? sim/não ");  
                sair = Console.ReadLine().ToLower(); 
                }catch{
                System.Console.WriteLine("erro!");
            }
            }
            return maior;
        }
    }
}
