using Microsoft.EntityFrameworkCore;
using RestaurantServiceSystem.API.Models;

namespace RestaurantServiceSystem.Infrastructure
{
    public class ProdutoDbContext : DbContext
    {
        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
