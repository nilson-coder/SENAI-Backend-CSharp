using System;
using Ex3.Controllers;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            ProdutoController produto = new ProdutoController();

            produto.CadastrarProduto();

        }
    }
}
