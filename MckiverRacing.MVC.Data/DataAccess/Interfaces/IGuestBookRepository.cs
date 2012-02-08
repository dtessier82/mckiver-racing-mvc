using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MckiverRacing.MVC.Data.DataAccess
{
    public interface IGuestBookRepository
    {
        Boolean Post(GuestBookContact guestbookcontact);
        IList<GuestBookContact> GetPostings();
        GuestBookContact GetPostingById(int id);
    }
}
