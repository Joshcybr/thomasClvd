using Microsoft.AspNetCore.Mvc;
using thomasClvd.Models;

namespace thomasClvd.Controllers
{
    public class User : Controller
    {

        public userTable usrtbl = new userTable();



        [HttpPost]
        public ActionResult About(userTable Users)
        {
            var result = usrtbl.insert_User(Users);
            return RedirectToAction("Privacy", "Home");
        }

        [HttpGet]
        public ActionResult About()
        {
            return View(usrtbl);
        }


    }
}