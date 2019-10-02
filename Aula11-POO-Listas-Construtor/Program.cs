using System;
using System.Collections.Generic;
using Aula11_POO_Listas_Construtor.Models;

namespace Aula11_POO_Listas_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos nossa classe com o metodo construtor passando os parametos
            ProdutoModel produto = new ProdutoModel(1, "Maça", "Verde", 3.5);

            // Chamos um atrubuto do objeto instanciado
            Console.WriteLine(produto.NomeProduto);

            // instanciamos nossa classe sem pasa parametros utilizando sobrecarga
            ProdutoModel produto_sobrecarga = new ProdutoModel();

            //Alimentamos nosso objeto que estava vazio
            produto_sobrecarga.IdProdoto = 1;
            produto_sobrecarga.NomeProduto = "Melão";
            produto_sobrecarga.Descricao = "Amarelo";
            produto_sobrecarga.Preco = 5.5;

            // Chamamoos a nossa lista que vai se dp objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel>();

            // Adicionamos objetos instanciados e atribumos em nossa lista
            prod.Add( new ProdutoModel( 1, "Cenoura", "Laraja", 2.30 ) );
            prod.Add( new ProdutoModel( 2, "Mamão", "Laraja", 2.30 ) );
            prod.Add( new ProdutoModel( 3, "beterraba", "Laraja", 2.30 ) );
            prod.Add( new ProdutoModel( 4, "Pastel", "Laraja", 2.30 ) );

            // Lemos os dados da nossa lista
            foreach(ProdutoModel p in prod){
                System.Console.WriteLine();
                System.Console.WriteLine(p.IdProdoto);
                System.Console.WriteLine(p.NomeProduto);
                System.Console.WriteLine(p.Descricao);
                System.Console.WriteLine(p.Preco);
                System.Console.WriteLine();
            }
            
            // Chamamos atraves do indice um atributo especifico
            System.Console.WriteLine(prod[3].NomeProduto);

        }
    }
}
