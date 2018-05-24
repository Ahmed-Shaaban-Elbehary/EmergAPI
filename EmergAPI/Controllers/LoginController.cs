using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmergAPI.Controllers
{
    public class LoginController : Controller
    {
        _dbContext db = new _dbContext();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Operator ope)
        {
            if (!ModelState.IsValid)
            {
                var operators = db.Operators.Where(e => e.Name.Equals(ope.Name) && e.Password.Equals(ope.Password)).FirstOrDefault();
                if (operators != null)
                {
                    Session["UserId"] = ope.Id.ToString();
                    Session["UserName"] = ope.Name.ToString();
                    return Redirect("/Home/Index");
                }
                else
                {
                    ModelState.AddModelError(" ", "Username or password is invalid");

                }
            }
            return View();
        }


        public ActionResult Logout()
        {

            Session.Clear();

            return RedirectToAction("Login");
        }

    }
}