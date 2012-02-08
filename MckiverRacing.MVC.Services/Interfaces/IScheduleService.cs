using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MckiverRacing.MVC.Services
{
   public  interface IScheduleService
    {
       IList<MckiverRacing.MVC.Data.Race_Schedule> GetScheduleByYear(int iYear);
       IList<MckiverRacing.MVC.Data.Race_Schedule> GetLatestResult(int iYear);
       IList<Int32> GetScheduleYears();
    }
}
