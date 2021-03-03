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
                        Id = 1,
                        Brand = "Adidas",
                        Model = "ZX750HD",
                        Colourway = "White / Grey / Orange",
                        PurchaseDate = new DateTime(2020, 12, 25),
                        Image = "https://sneakersimages.blob.core.windows.net/sneakers/IMG-4906.jpg"

                    },
                    new Sneaker()
                    {
                        Id = 2,
                        Brand = "Adidas",
                        Model = "Originals Stan Smith",
                        Colourway = "White / Green",
                        PurchaseDate = new DateTime(2020, 12, 25),
                        Image = "https://sneakersimages.blob.core.windows.net/sneakers/3EB6F1D7-D136-4615-91E2-F5E6C684C27D.JPG"
                    }
                };

            return lst.ToArray();
        }
    }
}
