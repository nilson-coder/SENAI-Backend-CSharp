using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args){
            double valor;
            double desconto;

        try{
            Console.WriteLine("Digite o valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem: ");
            desconto = double.Parse(Console.ReadLine().Replace("%", "")); 

            Console.WriteLine(CalculaDesconto(valor, desconto));
            
        }catch(Exception){
            System.Console.WriteLine("Os dados devem ser numericos");
        }

        }
        static double CalculaDesconto (double valor, double desconto){

            valor = valor - (valor * (desconto/100));

            return valor;

        }
    }
}
