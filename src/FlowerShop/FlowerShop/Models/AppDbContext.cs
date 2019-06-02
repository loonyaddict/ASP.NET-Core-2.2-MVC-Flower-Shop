using Microsoft.EntityFrameworkCore;

namespace FlowerShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Flower> Flowers { get; set; }

    }
}