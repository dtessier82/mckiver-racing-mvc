using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MckiverRacing.MVC.Data;

namespace MckiverRacing.MVC.Services
{
    public interface IScheduleResultsService
    {
        IList<Race_ScheduleResult> GetResultsBySchedule(int Schedule_ID);
    }
}
