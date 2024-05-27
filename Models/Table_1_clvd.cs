using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace thomasClvd.Models
{
   
        public class Table_1_clvd : Controller
        {//you changed the link from the database to the server ,it was  thomasclvd.database.windows.net
        public static string con_string = "Server=tcp:joshua-s.database.windows.net,1433;Initial Catalog = thomasclvd_; Persist Security Info=False;User ID =joshua;Password=123123J#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";

             public static SqlConnection con = new SqlConnection(con_string);
            public IActionResult Index()
            {
                return View();
            }
        }
    }

