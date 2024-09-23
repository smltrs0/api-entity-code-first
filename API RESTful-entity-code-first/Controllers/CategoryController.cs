using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_RESTful_entity_code_first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly StoreContext _context;

        public CategoryController(StoreContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _context.Categories.ToList();
        }

    }
}
