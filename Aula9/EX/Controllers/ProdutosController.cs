using System;
using System.IO;
using Aula9_POO.Models;

namespace Aula9_POO.Controllers
{
    public class ProdutosController
    {

        ProdutosModel produto = new ProdutosModel();
        public void CadastroProduto(){
            
            try{

                Console.WriteLine("Digite i ID do produto: ");
                produto.IdProduto = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite o nome do produto:");
                produto.NomeProdutos = Console.ReadLine();
                
                System.Console.WriteLine("Digite a descrição do produto:");
                produto.Descricao = Console.ReadLine();
                
                System.Console.WriteLine("Digite o preço do produto");
                produto.Preco = double.Parse(Console.ReadLine());

                // System.Console.WriteLine("Digite o ID do fornecedor");
                // produto.Fornecedores.IdFornecedor = int.Parse(Console.ReadLine());

                // System.Console.WriteLine("Digite o nome do fornecedor");
                // produto.Fornecedores.NomeFornecedor = Console.ReadLine();

            }catch (Exception ex){
                
                System.Console.WriteLine("Desculpe :( Houve um erro na aplicação");
                SalvarErros(ex);

            }

        }

        public void ExibirProduto(){
            System.Console.WriteLine(produto.IdProduto);
            System.Console.WriteLine(produto.NomeProdutos);
            System.Console.WriteLine(produto.Descricao);
            System.Console.WriteLine(produto.Preco);

            // System.Console.WriteLine(produto.Fornecedores.IdFornecedor);
            // System.Console.WriteLine(produto.Fornecedores.NomeFornecedor);

        }

        private void SalvarErros(Exception ex){

            StreamWriter txt = new StreamWriter("erro_log.txt", true);

            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex);
            txt.WriteLine();

            txt.Close();
            
        }

    }
}