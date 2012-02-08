using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MckiverRacing.MVC.Data.DataAccess{

    public interface IScheduleResultsRepository
    {
        IList<Race_ScheduleResult> GetResultsBySchedule(int Schedule_ID);
    }
}
