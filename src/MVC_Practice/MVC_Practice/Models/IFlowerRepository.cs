using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Practice.Models
{
    public interface IFlowerRepository
    {
        IEnumerable<Flower> GetAllFlowers();
        Flower GetFlowerById(int FlowerId);

    }
}
