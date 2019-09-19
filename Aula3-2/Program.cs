using System;

namespace Aula3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumuladora1 = 0, nota = 1, cont = 1;

            // Laço condicional - do / While
            do{
                Console.WriteLine("Digite nota do aluno: ");
                nota = int.Parse(Console.ReadLine());

                if(nota % 3 == 0){
                    acumuladora1 = acumuladora1 + nota;
                }
                cont ++;

            }while(cont <= 20);

                Console.WriteLine(acumuladora1);

        }
    }
}
