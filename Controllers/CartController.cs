using Microsoft.AspNetCore.Mvc;
using thomasClvd.Models;
using System.Collections.Generic;

namespace thomasClvd.Controllers
{
    public class CartController : Controller
    {
        private Database db = new Database();

        public IActionResult Index()
        {
            List<CartItem> cartItems = db.GetCartItems();
            return View(cartItems);
        }

        public IActionResult AddToCart(int id)
        {
            db.AddToCart(id, 1); // Assuming quantity is 1 for simplicity
            return RedirectToAction("Index", "ProductDisplay");
        }
    }
}
