using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MckiverRacing.MVC.Services;
using MckiverRacing.MVC.Data;

namespace MckiverRacing.MVC.Web.Controllers
{
    public class NewsController : Controller
    {

         INewsService _newsService;
         IList<News> _news;

        public NewsController(){

            _newsService = new NewsService();
        }

       [HttpGet]
        public ActionResult Details(int id){

            News _news = _newsService.GetByID(id);

            return View(_news);
        }

        public ActionResult Index()
        {
             _news = _newsService.GetLatestNews();
            
            return View(_news);
        }

    }
}
