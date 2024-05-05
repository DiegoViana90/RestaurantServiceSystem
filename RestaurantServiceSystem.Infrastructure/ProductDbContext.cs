using Microsoft.EntityFrameworkCore;
using RestaurantServiceSystem.Models;

namespace RestaurantServiceSystem.Infrastructure
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
        public DbSet<MenuItens> MenuItens { get; set; }
    }
}
