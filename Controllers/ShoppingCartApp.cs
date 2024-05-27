using Microsoft.AspNetCore.Mvc;

namespace thomasClvd.Controllers
{
    public class ShoppingCartApp : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout([FromBody] List<CartItem> cartItems)
        {
            // Process the checkout
            // Save cartItems to database, send email, etc.

            return Ok(new { success = true, message = "Checkout successful!" });
        }
    }

    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
   