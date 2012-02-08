using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MckiverRacing.MVC.Services;
using MckiverRacing.MVC.Data;
using MckiverRacing.MVC.Web.Models;

namespace MckiverRacing.MVC.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        #region "Service Interfaces"
        INewsService _newsService;
        IScheduleResultsService _resultsService;
        IScheduleService _schedService;
       
        #endregion

        #region "Properties"
        
        HomeViewModel _home;
        #endregion

        //Constructor
        public HomeController(){

            _newsService = new NewsService();
            _resultsService = new ScheduleResultsService();
            _schedService = new ScheduleService();

            _home = new HomeViewModel();
        }


        public ActionResult Index()
        {
            ViewData["Selected"] = "Home";
            //TODO: Make ViewDataModel for everyone for homepage
            _home.News = _newsService.GetTop3().ToList();
           IList<Race_Schedule> _sched = 
            _schedService.GetLatestResult(DateTime.Now.Year).ToList();

            foreach(Race_Schedule s in _sched){

                _home.Schedule.Add(MapModelToViewModel(s));
            }


            return View(_home);
        }

        public ActionResult About()
        {
            return View();
        }

         ScheduleViewModel MapModelToViewModel(Race_Schedule m){

           

                return (new ScheduleViewModel
                {
                    Schedule = m,
                    Results  = _resultsService.GetResultsBySchedule(m.ID).ToList()

                });
            }

        }
    }

