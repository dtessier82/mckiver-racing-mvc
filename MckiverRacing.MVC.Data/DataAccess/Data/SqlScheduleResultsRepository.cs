using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTConsulting.Common.Utilities.Database;

namespace MckiverRacing.MVC.Data.DataAccess.Data
{
    public class SqlScheduleResultsRepository : IScheduleResultsRepository
    {
        public IList<Race_ScheduleResult> GetResultsBySchedule(int Schedule_ID){

            using (IDbConnection con = DBUtils.SetConnection())
            {
                IDbCommand command = DBUtils.database.CreateStoreProcCommand("CALL MckiverRacing_GetRaceResultsBySchedule(?);", con);

                command = DBUtils.database.AddCommandParameters("_schedID", Schedule_ID, command);

                return this.PopulateRaceResults(command);
                
            }
        }


        private List<Race_ScheduleResult> PopulateRaceResults(IDbCommand command){

            
           using (IDataReader idr = command.ExecuteReader())
           {


               List<Race_ScheduleResult> _schedResults = new List<Race_ScheduleResult>();
               while (idr.Read())
               {
                   _schedResults.Add(new Race_ScheduleResult
                   {
                        Finish_Position = Helper.GetInt32(idr, "finish_pos"),
                       Finish_Time = Helper.GetDecimal(idr, "finish_time"),
                       Qualify_Position = Helper.GetInt32(idr, "qualify_pos"),
                       Qualify_Time = Helper.GetDecimal(idr, "qualify_time"),
                       ID = Helper.GetInt32(idr, "results_info_id"),
                       Class = new Race_Class{
                           ID = Helper.GetInt32(idr,"race_class_id"),
                           Description = Helper.GetString(idr,"class_name"),
                           Class_Name = Helper.GetString(idr,"class_name")
                  
                       }
                      
                   });
               }

               return _schedResults;

           }
        }
    }
}
