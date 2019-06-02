using Microsoft.AspNetCore.Mvc;
using FlowerShop.Models;
using FlowerShop.ViewModels;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlowerShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFlowerRepository flowerRepository;

        public HomeController(IFlowerRepository flowerRepository)
        {
            this.flowerRepository = flowerRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var flowers = flowerRepository
                .GetAllFlowers()
                .OrderBy(f => f.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to flower shop!",
                Flowers = flowers.ToList()
            };

            return View(homeViewModel);
        }
    }
}