namespace Aula9_POO.Models
{
    public class ProdutosModel
    {
        
        public int IdProduto {get; set;}

        public string NomeProdutos {get; set;}

        public string Descricao {get; set;}

        public double Preco {get; set;}

        public FornecedoresModel Fornecedores {get; set;}

    }
}