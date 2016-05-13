using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(); // using view template
        }

        public ActionResult WorkExperience()
        {
            //ViewBag.Message = "Your application description page.";


            return View();
        }

        public ActionResult Education()
        {
            //ViewBag.Message = "Your application description page.";


            return View();
        }

        public ActionResult Projects()
        {
            //ViewBag.Message = "Your application description page.";


            return View();
        }
      

        public ActionResult Contact()
        {
            ViewBag.Message = "Lets know more about each other on social media:";

            return View();
        }
    }
}