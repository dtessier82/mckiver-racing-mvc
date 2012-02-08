using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MckiverRacing.MVC.Data.DataAccess
{
    public class SqlSponsorsRepository : ISponsorsRepository
    {
        public IList<Sponsor> GetSponsors(){

            using (IDbConnection con = DBUtils.SetConnection())
            {
                //IDbCommand command = DBUtils.database.CreateCommand("CALL MckiverRacing_GetRaceResultsBySchedule(?);", con);

                //command = DBUtils.database.AddCommandParameters("_schedID", Schedule_ID, command);

                //return this.PopulateRaceResults(command);
                return null;

            }
        }
    }
}
