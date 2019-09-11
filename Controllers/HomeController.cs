using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wolff_MIS4200_1045.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is data for Wolff";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Cantact Info for Wolff.";

            return View();
        }
    }
}