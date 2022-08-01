namespace ProjetoPedidos.Dominio.Produtos;

public class Produto:Entidade
{
    public string Nome { get; set; }
    public int CategoriaId { get; set; }   
    public  Categoria Categoria { get; set; }
    public string Descricao { get; set; }
    public bool TemEstoque { get; set; }
    
}
