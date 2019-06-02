using System.Linq;

namespace FlowerShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Flowers.Any())
            {
                context.AddRange
                    (
                        new Flower {Name = "Rose", Price = 10.50M, ShortDescription = "They are red", LongDescription = "None of them comes without thorns!", FlowerOfTheWeek = true, ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Rose_flower_in_bundle.jpg/220px-Rose_flower_in_bundle.jpg", ImageUrl = "https://en.wikipedia.org/wiki/Rose#/media/File:Rose_flower_in_bundle.jpg" },
                        new Flower {Name = "Violet", Price = 5.20M, ShortDescription = "They are blue", LongDescription = "The heart-shaped leaves of V. odorata provide a free source of greens throughout a long growing season.", FlowerOfTheWeek = false, ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Viola_reichenbachiana_LC0128.jpg/220px-Viola_reichenbachiana_LC0128.jpg", ImageUrl = "https://en.wikipedia.org/wiki/Viola_(plant)#/media/File:Viola_reichenbachiana_LC0128.jpg" }
                    );
                context.SaveChanges();
            }
        }
    }
}