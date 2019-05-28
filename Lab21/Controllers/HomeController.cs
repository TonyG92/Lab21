using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab22.Controllers
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

        [HttpPost]

        public ActionResult Welcome(string userName, string firstName, string middleName, string lastName, string favoriteAnimal, string email, string phoneNumber, string password)
        {
            Models.User user = new Models.User();
            ViewBag.userName = userName;
            ViewBag.firstName = firstName;
            ViewBag.middleName = middleName;
            ViewBag.lastName = lastName;
            ViewBag.favoriteAnimal = favoriteAnimal;
            ViewBag.email = email;
            ViewBag.phoneNumber = phoneNumber;
            ViewBag.password = password;
            
            return View(user);
        }



    }
}