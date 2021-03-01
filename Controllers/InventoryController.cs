using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace sneakers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private static readonly string[]
            Brands =
                new [] { "Nike", "Jordan", "Adidas", "Converse", "Timberland", "Skechers" };

        private readonly ILogger<InventoryController> _logger;

        public InventoryController(ILogger<InventoryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Sneaker> Get()
        {
            var rng = new Random();

            var lst =
                new List<Sneaker>()
                {
                    new Sneaker()
                    {
                        Brand = "Nike",
                        Model = "BW/97",
                        Colourway = "Silver, Purple and White",
                        PurchaseDate = new DateTime(2017, 9, 1)
                    },
                    new Sneaker()
                    {
                        Brand = "Adidas",
                        Model = "Originals Jeans",
                        Colourway = "Red and White",
                        PurchaseDate = new DateTime(2019, 9, 1)
                    }
                };

            return lst.ToArray();
        }
    }
}
