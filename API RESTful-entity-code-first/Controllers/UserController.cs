using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_RESTful_entity_code_first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly StoreContext _context;

        public UserController(StoreContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users.ToList();
        }
    }
}
