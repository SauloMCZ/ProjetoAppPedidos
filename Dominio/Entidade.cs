namespace ProjetoPedidos.Dominio;

public abstract class Entidade

{
    public Entidade() 
    {
    Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string CriadoPor { get; set; }
    public DateTime CriadoEm { get; set; }
    public string EditadoPor { get; set; }
    public DateTime EditadoEm { get; set; }

}

