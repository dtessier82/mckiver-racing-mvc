using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using DTConsulting.Common.Utilities.Database;

namespace MckiverRacing.MVC.Data.DataAccess
{
    public class SqlNewsRepository 
        : INewsRepository 

    {

      public News GetNewsByID(int id){

          using(IDbConnection con = DBUtils.SetConnection()){
              IDbCommand command = DBUtils.database.CreateCommand("SELECT * FROM News WHERE news_id = ?", con);
              command = DBUtils.database.AddCommandParameters("@id", id, command);

               using(IDataReader idr = command.ExecuteReader()){

                   News _news = new News();

                   while(idr.Read()){

                       _news.ID = Helper.GetInt32(idr, "news_id");
                        _news.News_Title = Helper.GetString(idr, "news_title");
                        _news.Description = Helper.GetString(idr, "news_description");
                        _news.News_Schort_Description = Helper.GetString(idr,"news_description").Substring(0,50);
                        _news.Created_Date = Helper.GetDateTime(idr, "created_date");
                   }

                   return _news;
               }

          }
      }

        public IList<News> GetLatestNews(){

            using(IDbConnection con = DBUtils.SetConnection()){
                using (IDbCommand command = DBUtils.database.CreateCommand("SELECT * FROM News ORDER BY Created_Date DESC",con))
                {

                    return this.PopulateNewsModel(command);
                }
            }
            
           
        }

        public IList<News> GetTop3()
        {
            using (IDbConnection con = DBUtils.SetConnection()){
                using (IDbCommand command = DBUtils.database.CreateCommand("SELECT * FROM News ORDER BY Created_Date DESC LIMIT 3",con))
                {

                    return this.PopulateNewsModel(command);
                }
            }


        }

        private List<News> PopulateNewsModel(IDbCommand cmd)
        {

            using (IDataReader idr = cmd.ExecuteReader())
            {

                List<News> _newsList = new List<News>();

                while (idr.Read())
                {

                    _newsList.Add(new News
                    {
                        ID = Helper.GetInt32(idr, "news_id"),
                        News_Title = Helper.GetString(idr, "news_title"),
                        Description = Helper.GetString(idr, "news_description"),
                        News_Schort_Description = Helper.GetString(idr,"news_description").Substring(0,50),
                        Created_Date = Helper.GetDateTime(idr, "created_date")


                    });
                }

                return _newsList;
            }
        }
    }
}
