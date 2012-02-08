using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MckiverRacing.MVC.Data.DataAccess;
using MckiverRacing.MVC.Data;

namespace MckiverRacing.MVC.Services
{
    public class ScheduleService : IScheduleService
    {
        IScheduleRepository _schedRepo;

        public ScheduleService(){

            _schedRepo = new SqlScheduleRepository();
        }

        public IList<Race_Schedule> GetScheduleByYear(int iYear){

            return _schedRepo.GetScheduleByYear(iYear).ToList();

        }

        public IList<Race_Schedule> GetLatestResult(int iYear)
        {

            return _schedRepo.GetLatestResult(iYear).ToList();

        }

         public IList<Int32> GetScheduleYears(){

             return _schedRepo.GetScheduleYears();
        }
    }
}
