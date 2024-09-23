using DB;
using Microsoft.AspNetCore.Mvc;

namespace API_RESTful_entity_code_first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly StoreContext _context;

        public ItemController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _context.Items.ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public Item Get(int id)
        {
            return _context.Items.Find(id);
        }
    }
}
