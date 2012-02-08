using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MckiverRacing.MVC.Data;

namespace MckiverRacing.MVC.Web.Models
{
    public class ScheduleViewModel
    {
        public Race_Schedule Schedule { get; set; }
        public List<Race_ScheduleResult> Results { get; set; }
        public List<Int32> ScheduleYears { get; set; }

        public  ScheduleViewModel(){
            Results = new List<Race_ScheduleResult>();
            ScheduleYears = new List<int>();
        }
    }
}