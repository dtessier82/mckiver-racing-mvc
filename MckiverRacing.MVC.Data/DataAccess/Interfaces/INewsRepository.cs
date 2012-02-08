using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MckiverRacing.MVC.Data.DataAccess
{
    public interface INewsRepository {

        IList<News> GetLatestNews();
        IList<News> GetTop3();
        News GetNewsByID(int id);

    }

}
