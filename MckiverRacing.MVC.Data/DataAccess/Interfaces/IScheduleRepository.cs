using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MckiverRacing.MVC.Data.DataAccess
{
    public interface IScheduleRepository
    {
       IList<Race_Schedule> GetScheduleByYear(int iYear);
       IList<Int32> GetScheduleYears();
       IList<Race_Schedule> GetLatestResult(int iYear);
    }
}
