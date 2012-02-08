using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MckiverRacing.MVC.Data;

namespace MckiverRacing.MVC.Web.Models
{
    public class HomeViewModel
    {

        public List<ScheduleViewModel> Schedule { get; set; }
       // public List<Race_ScheduleResult> Results { get; set; }
        public List<News> News { get; set; }

        public  HomeViewModel(){
            Schedule = new List<ScheduleViewModel>();
            //Results = new List<Race_ScheduleResult>();
            News = new List<News>();
        }
            
    }
}