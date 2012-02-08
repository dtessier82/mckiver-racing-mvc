using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MckiverRacing.MVC.Web.Controllers
{
    public class BioController : Controller
    {
        //
        // GET: /Bio/

        public ActionResult Index()
        {
            ViewData["Selected"] = "Bio";
            return View();
        }

    }
}
