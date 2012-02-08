using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTConsulting.Common.Utilities.Database;

namespace MckiverRacing.MVC.Data.DataAccess
{
   public  class SqlScheduleRepository : IScheduleRepository
    {
       public IList<Race_Schedule> GetScheduleByYear(int iYear)
       {

             using(IDbConnection con = DBUtils.SetConnection()){

                 IDbCommand command = DBUtils.database.CreateStoreProcCommand("CALL MckiverRacing_GetSchedule(?);", con);
                 command = DBUtils.database.AddCommandParameters("_year", iYear, command);
                 return this.PopulateScheduleList(command);
                
             }
          
       }

       public IList<Race_Schedule> GetLatestResult(int iYear)
       {

           using (IDbConnection con = DBUtils.SetConnection())
           {

               IDbCommand command = DBUtils.database.CreateStoreProcCommand("CALL MckiverRacing_GetLatestResults(?);", con);
               command = DBUtils.database.AddCommandParameters("_year", iYear, command);
               return this.PopulateScheduleList(command);

           }

       }

       private List<Race_Schedule> PopulateScheduleList(IDbCommand cmd)
       {

           using (IDataReader idr = cmd.ExecuteReader())
           {


               List<Race_Schedule> _sched = new List<Race_Schedule>();
               while (idr.Read())
               {

                   Race_Schedule sched =
                   new Race_Schedule();
                   sched.ID = Helper.GetInt32(idr, "schedule_id");
                   sched.Description = Helper.GetString(idr, "schedule_long_description");
                   sched.Schedule_Year = Helper.GetInt32(idr, "schedule_year");
                   sched.Start_Date = Helper.GetDateTime(idr, "schedule_start_date");
                   sched.End_Date = Helper.GetDateTime(idr, "schedule_end_date");
                   sched.Series = new Race_Series
                   {
                       ID = Helper.GetInt32(idr,"series_id"),
                       Description = Helper.GetString(idr,"series_description"),
                       Series_Name = Helper.GetString(idr,"series_description")
                   };

                   sched.Track = new Race_Track
                   {
                       ID = Helper.GetInt32(idr,"track_id"),
                       Description = Helper.GetString(idr,"track_name"),
                       Track_Name = Helper.GetString(idr,"track_name")
                   };

                   _sched.Add(sched);



               }

               return _sched;
           }
       }

       public IList<Int32> GetScheduleYears()
       {

           using (IDbConnection con = DBUtils.SetConnection())
           {
               IDbCommand command = DBUtils.database.CreateCommand("SELECT distinct schedule_year FROM RACE_SCHEDULE", con);
              
                using (IDataReader idr = command.ExecuteReader())
                {
                    IList<Int32> _years = new List<Int32>();

                    while(idr.Read()){

                        _years.Add(Helper.GetInt32(idr,"schedule_year"));
                    }

                    return _years;
                }
           }

       }
    }
}
