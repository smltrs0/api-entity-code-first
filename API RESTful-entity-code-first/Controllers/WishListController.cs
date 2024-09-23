using DB;
using Microsoft.AspNetCore.Mvc;

namespace API_RESTful_entity_code_first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        private readonly StoreContext _context;

        public WishListController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("{user_id}")]
        public ActionResult<WishList> Get(int user_id)
        {
            var items = _context.WishLists
                    .Where(w => w.UserId == user_id)
                    .Select(w => w.Item)
                    .ToList();

            if (!items.Any()){
                return NotFound();
            }

            return Ok(items.Select(i => new {
                i.ItemId,
                i.Name,
                i.Description,
                i.Price,
                i.CategoryId,
                i.Category
            }));
        }

        [HttpDelete]
        [Route("{user_id}/{item_id}")]
        public ActionResult Delete(int user_id) {
            var wishList = _context.WishLists.Find(user_id);
            if (wishList == null)
            {
                return NotFound();
            }
            _context.WishLists.Remove(wishList);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("{user_id}/{item_id}")]
        public ActionResult<WishList> Post(int user_id, int item_id)
        {
            var wishList = new WishList { UserId = user_id, ItemId = item_id };
            _context.WishLists.Add(wishList);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { user_id = wishList.UserId }, wishList);
        }

    }
}