using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uma empresa com X funcionários precisa saber a média de seus salários. Faça um
            //algoritmo para ler a quantidade de funcionários e o salário de cada um e escrever a
            //média dos salários.
            
            int x;
            double salario, acum = 0;
            int cont = 1;

            Console.WriteLine("Digite a quantidade de funcionarios: ");
            x = int.Parse(Console.ReadLine());

            while(cont<=x){
                Console.WriteLine($"Digite o salário {cont}: ");
                salario = int.Parse(Console.ReadLine());
                acum = acum + salario;
                cont ++;
            }
            Console.WriteLine($"A média dos salários é de {acum/x}");
        }
    }
}
