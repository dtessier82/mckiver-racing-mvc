using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTConsulting.Common.Utilities.Database;
using System.Data;
using System.Data.Common;


namespace MckiverRacing.MVC.Data.DataAccess
{
   
    public class DBUtils : DataWorker
    {

        
        public static IDbConnection SetConnection(){

            return database.CreateOpenConnection();
        }
    }
}
