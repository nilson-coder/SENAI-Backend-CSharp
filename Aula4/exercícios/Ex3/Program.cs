using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //Um site na web precisa registrar 12 produtos de um fornecedor, crie um vetor para
            //representar estes produtos com os seguintes atributos: Nome do produto, Cor,
            //Tamanho e Preço.

            string[] produto = new string[12];
            string[] Cor = new string[12];
            string[] Tamanho = new string[12];
            string[] Preço = new string[12];

            for(int i = 0; i <= 11; i++){
            Console.WriteLine("Digite o produto");
            produto[i] = Console.ReadLine();
            Console.WriteLine("Digite o produto");
            produto[i] = Console.ReadLine();
            Console.WriteLine("Digite o produto");
            produto[i] = Console.ReadLine();
            Console.WriteLine("Digite o produto");
            produto[i] = Console.ReadLine();

            }
            
        }
    }
}
