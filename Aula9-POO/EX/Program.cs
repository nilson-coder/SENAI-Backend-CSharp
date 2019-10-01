using System;
using Aula9_POO.Controllers;

namespace Aula9_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProdutosController produto1 = new ProdutosController();

            produto1.CadastroProduto();

            produto1.ExibirProduto();

        }
    }
}
