using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
             double valor;
           
           Console.Write("Escreva o preço total:");
           valor=double.Parse(Console.ReadLine());

            if(valor<100){
                valor = valor - 25;
            }
            Console.Write("Preço a ser pago: "+ valor);
        }
    }
}
