using Microsoft.EntityFrameworkCore;
using Projeto_06_ApiCatalogo.Models;

namespace Projeto_06_ApiCatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
    }
}
