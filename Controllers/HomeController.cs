using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using thomasClvd.Models;


namespace thomasClvd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController>_logger;

        private readonly IHttpContextAccessor _httpContextAccessor; // Add IHttpContextAccessor

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor; // Initialize IHttpContextAccessor
        }

        public IActionResult Index()
        {
            // Retrieve all products from the database
            List<productTable> products = productTable.GetAllProducts();

            // Retrieve userID from session
            int? userID = _httpContextAccessor.HttpContext.Session.GetInt32("UserID");

            // Pass products and userID to the view
            ViewData["Products"] = products;
            ViewData["UserID"] = userID;

            return View();
        }





        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult MyWork()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult cart()
        {
            return View();
        }
        public IActionResult BankingDetails()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

}