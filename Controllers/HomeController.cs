using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_t2009e.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // This is the code of branch main
            return View();
        }

        public ActionResult About()
        {
            //This is the code of master branch
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}