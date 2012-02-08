using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MckiverRacing.MVC.Web.Controllers
{
    public class SponsorsController : Controller
    {
        //
        // GET: /Sponsor/

        public ActionResult Index()
        {
            ViewData["Selected"] = "Sponsors";
            return View();
        }

    }
}
