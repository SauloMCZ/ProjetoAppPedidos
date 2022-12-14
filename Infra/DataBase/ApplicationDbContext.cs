using Microsoft.EntityFrameworkCore;
using ProjetoPedidos.Dominio.Produtos;

namespace ProjetoPedidos.Infra.DataBase;

public class ApplicationDbContext:DbContext
{
    public DbSet<Produto>Produtos { get; set; }

    public DbSet<Categoria> Categorias { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Produto>().Property(p => p.Descricao).HasMaxLength(500);
        builder.Entity<Produto>().Property(p => p.Nome).IsRequired();
        builder.Entity<Categoria>().Property(c => c.Nome).IsRequired();
    }
    protected override void ConfigureConventions(ModelConfigurationBuilder configuration) 
    {
        configuration.Properties<string>().HaveMaxLength(150);
     }
}
