using Microsoft.EntityFrameworkCore;
using MercadinhoChapadao.Models;

namespace MercadinhoChapadao.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração da precisão e escala para a propriedade Preco
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Produto>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
