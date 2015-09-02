using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnet_starter.Controllers
{
    public class TutorialController : Controller
    {
        //
        // GET: /Tutorial/Deployment_and_Buildpacks

        [AllowAnonymous]
        public ActionResult Deployment_and_Buildpacks()
        {
            return View();
        }

        // GET: /Tutorial/Console_App
        [AllowAnonymous]
        public ActionResult Console_App()
        {
            return View();
        }

        // GET: /Tutorial/Manifest
        [AllowAnonymous]
        public ActionResult Manifest()
        {
            return View();
        }

        // GET: /Tutorial/Packages_from_NuGet
        [AllowAnonymous]
        public ActionResult Packages_from_NuGet()
        {
            return View();
        }

        // GET: /Tutorial/App_Services_Through_Code
        [AllowAnonymous]
        public ActionResult App_Services_Through_Code()
        {
            return View();
        }

        // GET: /Tutorial/App_Services_Through_Config
        [AllowAnonymous]
        public ActionResult App_Services_Through_Config()
        {
            return View();
        }

        // GET: /Tutorial/Remote_Debugging
        [AllowAnonymous]
        public ActionResult Remote_Debugging()
        {
            return View();
        }


    }
}
