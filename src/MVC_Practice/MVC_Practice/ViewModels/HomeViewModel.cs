using MVC_Practice.Models;
using System.Collections.Generic;

namespace MVC_Practice.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Flower> Flowers { get; set; }
    }
}