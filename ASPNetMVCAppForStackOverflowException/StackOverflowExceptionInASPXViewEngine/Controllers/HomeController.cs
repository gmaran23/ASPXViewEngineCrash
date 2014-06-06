using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StackOverflowExceptionInASPXViewEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Index";

            return View();
        }

        public ActionResult AccessDenied()
        {
            ViewBag.Message = "AccessDenied";

            return View();
        }

        public ActionResult AccessDeniedForCrash()
        {
            ViewBag.Message = "AccessDeniedForCrash";

            return View();
        }

        public ActionResult ViewDoesNotExist()
        {
            ViewBag.Message = "ViewDoesNotExist";

            return View();
        }
    }
}
