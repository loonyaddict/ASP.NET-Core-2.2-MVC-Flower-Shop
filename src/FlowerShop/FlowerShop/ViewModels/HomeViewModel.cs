using FlowerShop.Models;
using System.Collections.Generic;

namespace FlowerShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Flower> Flowers { get; set; }
    }
}