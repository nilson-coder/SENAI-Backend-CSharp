namespace Aula11_POO_Listas_Construtor.Models
{
    public class ProdutoModel
    {
        public int IdProdoto {get; set;}
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }


        // Utilizamos sobrecarga para poder instanciar passando ou não os atributos/parametros/argumento
        public  ProdutoModel(){

        }
        
        public ProdutoModel(int idprduto, string nomeproduto, string descricao, double preco){
            this.IdProdoto = idprduto;
            this.NomeProduto = nomeproduto;
            this.Descricao = descricao;
            this.Preco = preco;
        }
    }
}