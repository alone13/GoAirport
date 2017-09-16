using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace goAirport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Khách hàng là thượng đế";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Chúng tôi sinh ra để phục vụ các bạn";

            return View();
        }
    }
}