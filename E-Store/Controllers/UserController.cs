using E_Store.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Store.Controllers
{
    public class UserController : Controller
    {
        private readonly mydb db;
        public UserController(mydb _db)
        {
            this.db = _db;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(users p)
        {
            var check = db.Users.Where(a => a.usr_email == p.usr_email && a.usr_password == p.usr_password).FirstOrDefault();

            if (check != null)
            {

                HttpContext.Session.SetString("firstname", check.usr_name.ToString());
               
                return RedirectToAction("Dashboard");

            }

            else
            {
                ViewBag.msg = "Not Login";

            }
            return View();
        }
    }
}
