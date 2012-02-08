using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTConsulting.Common.Utilities.Database;

namespace MckiverRacing.MVC.Data.DataAccess
{
    public class SqlGuestBookRepository : IGuestBookRepository
    {
        public Boolean Post(GuestBookContact guestbookcontact){

            Boolean flag = false;
            using (IDbConnection con = DBUtils.SetConnection())
            {
                
                IDbCommand command = DBUtils.database.CreateStoreProcCommand("CALL McKiverRacing_GuestbookPost(?,?,?);", con);

                command = DBUtils.database.AddCommandParameters("_name",guestbookcontact.Contact_Name, command);
                command = DBUtils.database.AddCommandParameters("_email", guestbookcontact.Contact_Email, command);
                command = DBUtils.database.AddCommandParameters("_comment", guestbookcontact.Comment, command);

                int ret = command.ExecuteNonQuery();

                if(ret == 1){

                    flag = true;
                }

                return flag;

            }
            
        }
        public IList<GuestBookContact> GetPostings() {

            using (IDbConnection con = DBUtils.SetConnection())
            {
                using (IDbCommand command = DBUtils.database.CreateCommand("SELECT * FROM GuestBook ORDER BY date_created DESC", con))
                {

                    return this.PopulateGuestBookContactList(command);
                }
            }
            
        
        }

        public GuestBookContact GetPostingById(int id) { throw new Exception("Not Yet Implementated"); }
    
        private IList<GuestBookContact> PopulateGuestBookContactList(IDbCommand cmd){

            using (IDataReader idr = cmd.ExecuteReader())
            {

                IList<GuestBookContact> _GBList = new List<GuestBookContact>();

                while (idr.Read())
                {


                    _GBList.Add(new GuestBookContact
                    {
                        ID = Helper.GetInt32(idr, "guestbook_id"),
                        Comment = Helper.GetString(idr, "comment"),
                        Contact_Name = Helper.GetString(idr, "name"),
                        Contact_Email = Helper.GetString(idr, "email"),
                        Date_Entered = Helper.GetDateTime(idr, "date_created")


                    });
                }

                return _GBList;
            }
        }
    
    }
}
