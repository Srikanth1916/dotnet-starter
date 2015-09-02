using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnet_starter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Read through these articles to learn how this app was deployed, packaged, debugged and connected to application services.  Once you are done, you can use this ASP.NET MVC 4.5 app as a starting point for your own development efforts.";
            return View();
        }

    }
}
