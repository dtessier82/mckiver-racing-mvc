using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MckiverRacing.MVC.Data.DataAccess;
using MckiverRacing.MVC.Data;

namespace MckiverRacing.MVC.Services
{
    public class NewsService : INewsService
    {
        INewsRepository _newsRepo = null;
   
        public NewsService(){

            _newsRepo = new SqlNewsRepository();
        }

        public IList<News> GetLatestNews(){

            return _newsRepo.GetLatestNews().ToList();
        }

        public IList<News> GetTop3()
        {

            return _newsRepo.GetTop3().ToList();
        }

        public News GetByID(int id){

            return _newsRepo.GetNewsByID(id);
        }
    }
}
