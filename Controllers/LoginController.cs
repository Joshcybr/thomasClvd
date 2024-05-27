using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using thomasClvd.Models;

namespace thomasClvd.Controllers
{
    public class LoginController : Controller
    {
        public static string con_string = "Server=tcp:joshua-s.database.windows.net,1433;Initial Catalog = thomasclvd_; Persist Security Info=False;User ID =joshua;Password=123123J#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";

            private readonly LoginModel login;

            public LoginController()
            {
                login = new LoginModel();
            }

            [HttpPost]
            public ActionResult Privacy(string email, string name)
            {
                var loginModel = new LoginModel();
                int userID = loginModel.SelectUser(email, name);
                if (userID != -1)
                {
                    // Store userID in session
                    HttpContext.Session.SetInt32("UserID", userID);

                    // User found, proceed with login logic (e.g., set authentication cookie)
                    // For demonstration, redirecting to a dummy page
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // User not found, handle accordingly (e.g., show error message)
                    return View("LoginFailed");
                }
            }
        }
    }