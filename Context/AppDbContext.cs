using e_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Carro> Carros { get; set; }
    }
}
