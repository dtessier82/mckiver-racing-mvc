using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MckiverRacing.MVC.Services;
using MckiverRacing.MVC.Data;
using MckiverRacing.MVC.Web.Models;
using System.Web.Routing;

namespace MckiverRacing.MVC.Web.Controllers
{
    public class ScheduleController : Controller
    {
        IScheduleService _scheService;
        IScheduleResultsService _schedResultsService;

        IList<ScheduleViewModel> _sched;


        public ScheduleController(){

            _scheService = new ScheduleService();

        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewData["Selected"] = "Sched";
            return RedirectToAction("Details", "Schedule", new { id = 2011 });
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            ViewData["Selected"] = "Sched";

            ViewData["SelectedYear"] = id.ToString() + " - Season";

           IList<Race_Schedule> _schedules = _scheService.GetScheduleByYear(id);
            _schedResultsService = new ScheduleResultsService();

            _sched = new List<ScheduleViewModel>();

            foreach (Race_Schedule r in _schedules.ToList()){

                _sched.Add(MapModelToViewModel(r));
            }
            

            return View(_sched);
        }

        ScheduleViewModel MapModelToViewModel(Race_Schedule m){

            _schedResultsService = new ScheduleResultsService();

                return (new ScheduleViewModel
                {
                    Schedule = m,
                    Results  = _schedResultsService.GetResultsBySchedule(m.ID).ToList()

                });
            }

        }

}

