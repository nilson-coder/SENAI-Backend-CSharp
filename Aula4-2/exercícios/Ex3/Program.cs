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

            string[] Produto = new string[12];
            string[] cor = new string[12];
            string[] tamanho = new string[12];
            double[] preco = new double[12];

            for(int i = 1; i <= 11; i++){

                Console.Write("Digite o produto: ");
                Produto[i] = Console.ReadLine();

                Console.Write("Digite a cor: ");
                cor[i] = Console.ReadLine();

                Console.Write("Digite o tamanho: ");
                tamanho[i] = Console.ReadLine();

                Console.Write("Digite o preço: ");
                preco[i] = double.Parse(Console.ReadLine());

            }


            for(int i = 1; i < Produto.Length ; i++){

                Console.WriteLine(Produto[i]);
                Console.WriteLine(cor[i]);
                Console.WriteLine(tamanho[i]);
                Console.WriteLine(preco[i]);
                
            }
            
        }
    }
}
