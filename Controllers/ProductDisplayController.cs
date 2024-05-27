using Microsoft.AspNetCore.Mvc;
using thomasClvd.Models;
using System.Collections.Generic;
using TH.Models;

namespace thomasClvd.Controllers
{
    public class ProductDisplayController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var products = ProductDisplayModel.SelectProducts();
            return View(products);
        }
    }
}