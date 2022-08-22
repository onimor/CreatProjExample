using Microsoft.AspNetCore.Mvc;
using ProjExample.Shared;

namespace ProjExample.Server.Controllers
{
    [ApiController]
    [Route("Categories")]
    public class CategoriesController : ControllerBase
    {
        
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ILogger<CategoriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Ñategories> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Ñategories
            {
                Url = $"Categori/{index}",
                Name = index.ToString()
            })
            .ToArray();
        }
    }
}