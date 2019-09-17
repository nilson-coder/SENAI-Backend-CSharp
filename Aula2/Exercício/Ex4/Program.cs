using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;

            Console.Write("Digite o preço total: ");
            valor=float.Parse(Console.ReadLine());

            if(valor>=100 && valor<=1000){
                valor = valor*0.15;
            }
            Console.Write("Preco Total "+ valor);
        }
    }
}
