using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace thomasClvd.Models
{
    public class Table_1_clvd : Controller
    {
        public static string con_string = "Server=tcp:thomasclvd.database.windows.net,1433;Initial Catalog=thomasClvd;Persist Security Info=False;User ID=JoshuaThomas;Password=0825521641Jt#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection con = new SqlConnection (con_string);
        public IActionResult Index()
        {
            return View();
        }
    }
}
