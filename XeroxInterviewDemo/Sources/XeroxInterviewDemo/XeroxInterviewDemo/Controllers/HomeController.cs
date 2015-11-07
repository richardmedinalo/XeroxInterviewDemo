using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XeroxInterviewDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Interviews";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "XeroxInterviewDemo";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me";

            return View();
        }
    }
}
