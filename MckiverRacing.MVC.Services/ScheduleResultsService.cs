using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MckiverRacing.MVC.Data.DataAccess;
using MckiverRacing.MVC.Data.DataAccess.Data;

namespace MckiverRacing.MVC.Services
{
    public class ScheduleResultsService : IScheduleResultsService
    {
        IScheduleResultsRepository _SchedResultsRepo = null;

        public ScheduleResultsService(){

            _SchedResultsRepo = new SqlScheduleResultsRepository();
        }

        public IList<MckiverRacing.MVC.Data.Race_ScheduleResult> GetResultsBySchedule(int Schedule_ID){

            return _SchedResultsRepo.GetResultsBySchedule(Schedule_ID);

        }

       
    }
}
