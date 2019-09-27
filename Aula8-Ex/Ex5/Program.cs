using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] numero = {};
            Console.WriteLine( CalculaMedia(numero) );

        }

        static double CalculaMedia( double[] valores){

            int num = 0;
            string sair = "";
            int num2 = 0;

            while(sair != "sim"){
                try{
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                for(int i = 0; i <= num.ToString().Length; i++){
                    num2 = num2 + num;
                }

                Console.Write("Deseja sair ? sim/não ");  
                sair = Console.ReadLine().ToLower(); 
                }catch{
                Console.WriteLine("erro!");
            }
            }
            return num2;
        }

    }
}
