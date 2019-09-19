using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // // Laço contado - for - incremento (+)
            // // X++, X=X+1, X+=1 tudo igual
             for(int cont = 1; cont <= 100; cont++){

                 // Verificamos se o número é diferente de pares
                 if(cont % 2 != 0){
                     Console.WriteLine("FOR 0-100 - " + cont);
                 }
             }

             // Laço contado - for - Decremento (-)
             for(int cont2 = 100; cont2 >= 0 ; cont2--){

                 // Verificamos se o número é diferente de pares
                 if(cont2 % 2 != 0){
                     Console.WriteLine("FOR 100-0 - " + cont2);
                 }
             }

            // Laço condicional - WHILE
            double  acumuladora = 0;
            double  nota        = 0;
            int     cont3        = 0;
            string  sair        = "";

            while(sair != "sim"){
                
                Console.WriteLine("Digite a nota de um aluno: ");
                nota = double.Parse( Console.ReadLine() );
                
                acumuladora += nota;
                cont3++;

                Console.Write("Deseja sair da aplicação? sim/nao ");
                sair = Console.ReadLine().ToLower();
                }

            Console.WriteLine("Média das notas : " + (acumuladora / cont3) );
            
            }
        }
    }

