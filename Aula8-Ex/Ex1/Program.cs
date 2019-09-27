using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args){
            double valor;
            double desconto;

            Console.WriteLine("Digite o valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem: ");
            desconto = double.Parse(Console.ReadLine()); 

            Console.WriteLine(CalculaDesconto(valor, desconto));
        }

        static double CalculaDesconto (double valor, double desconto){

        valor = valor - ((desconto/100)*valor);

        return valor;
        }
    }
}
