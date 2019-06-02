using System.Collections.Generic;
using System.Linq;

namespace FlowerShop.Models
{
    public class FlowerRepository : IFlowerRepository
    {
        private readonly AppDbContext dbContext;

        public FlowerRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Flower> GetAllFlowers() =>
            dbContext.Flowers;

        public Flower GetFlowerById(int flowerId) =>
            dbContext.Flowers
            .FirstOrDefault(f => f.Id == flowerId);
    }
}