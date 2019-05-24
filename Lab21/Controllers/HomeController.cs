using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "This is your register";

            return View();
 
        }

        public ActionResult Welcome(string firstName, string lastName, string email, string phoneNumber, string password)
        {
            ViewBag.firstName = firstName;
            ViewBag.lastName = lastName;
            ViewBag.email = email;
            ViewBag.phoneNumber = phoneNumber;
            ViewBag.password = password;

            return View();
        }
    }
}