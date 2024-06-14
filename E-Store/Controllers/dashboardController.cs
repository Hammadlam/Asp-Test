using E_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_Store.Controllers
{
    public class dashboardController : Controller {


        private readonly mydb db;
        public dashboardController(mydb _db)
        {
            this.db = _db;
        }
        public IActionResult dashboard()
        {
            return View();
        }
        public IActionResult addproducts()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult addproducts(products p)
        {
          
            db.Products.Add(p);
            db.SaveChanges();
            ModelState.Clear();
             return RedirectToAction("ViewProducts");
            
        }

        public IActionResult ViewProducts()
        {
            var b = db.Products.ToList();
            return View(b);
        }

        public IActionResult edit(int id)
        {
            var row = db.Products.Find(id);
            return View(row);
        }
        [HttpPost]
        public IActionResult edit(products a, int id)
        {
            var dbrow = db.Products.Find(id);
            dbrow.product_name = a.product_name;
            dbrow.prod_type = a.prod_type;
            dbrow.prod_size = a.prod_size;
            dbrow.prod_color = a.prod_color;
            db.SaveChanges();
            return RedirectToAction("ViewProducts");
        }
        public IActionResult delete(int id)
        {
            var d = db.Products.Find(id);
            db.Products.Remove(d);
            db.SaveChanges();
            return RedirectToAction("ViewProducts");
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
