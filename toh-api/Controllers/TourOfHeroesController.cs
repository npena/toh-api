using Microsoft.AspNetCore.Mvc;

namespace toh_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TourOfHeroesController : ControllerBase
    {
        private static readonly Hero[] Heroes = new[]
        {
            new Hero{ id = 1, name = "Dr Nice" },
            new Hero{ id = 2, name = "Narco Polo"},
            new Hero{ id = 3, name = "Bombasto"},
            new Hero{ id = 4, name = "Celeritas"},
            new Hero{ id = 5, name = "Magneta"},
            new Hero{ id = 6, name = "Rubber Man"},
            new Hero{ id = 7, name = "Dynama"},
            new Hero{ id = 8, name = "Dr IQ"},
            new Hero{ id = 8, name = "Magma"},
            new Hero{ id = 9, name = "Tornado"}
    };


        private readonly ILogger<TourOfHeroesController> _logger;

        public TourOfHeroesController(ILogger<TourOfHeroesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return Heroes;
        }
    }
} 