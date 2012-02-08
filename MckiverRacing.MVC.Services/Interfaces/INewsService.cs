using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MckiverRacing.MVC.Data;

namespace MckiverRacing.MVC.Services
{
    public interface INewsService
    {
        IList<MckiverRacing.MVC.Data.News> GetLatestNews();
        IList<MckiverRacing.MVC.Data.News> GetTop3();
        News GetByID(int id);
    }
}
