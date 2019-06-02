using System;
using System.Linq;
using System.Collections.Generic;

namespace MVC_Practice.Models
{
    public class MockFlowerRepository : IFlowerRepository
    {
        private List<Flower> flowers;

        public MockFlowerRepository()
        {
            if (flowers == null)
                InitializeFlowers();
        }

        private void InitializeFlowers()
        {
            flowers = new List<Flower>
            {
                new Flower{
                    Id = 1,
                    Name = "Rose",
                    Price = 10.50M,
                    ShortDescription = "They are red",
                    LongDescription = "None of them comes without thorns!",
                    FlowerOfTheWeek = true,
                    ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Rose_flower_in_bundle.jpg/220px-Rose_flower_in_bundle.jpg",
                    ImageUrl = "https://en.wikipedia.org/wiki/Rose#/media/File:Rose_flower_in_bundle.jpg"
                },
                new Flower{
                    Id = 2,
                    Name = "Violet",
                    Price = 5.20M,
                    ShortDescription = "They are blue",
                    LongDescription = "The heart-shaped leaves of V. odorata provide a free source of greens throughout a long growing season.",
                    FlowerOfTheWeek = false,
                    ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Viola_reichenbachiana_LC0128.jpg/220px-Viola_reichenbachiana_LC0128.jpg",
                    ImageUrl = "https://en.wikipedia.org/wiki/Viola_(plant)#/media/File:Viola_reichenbachiana_LC0128.jpg"}
            };
        }

        public IEnumerable<Flower> GetAllFlowers() => 
            flowers;

        public Flower GetFlowerById(int flowerId) =>
            flowers.FirstOrDefault(f => flowerId == f.Id);
    }
}