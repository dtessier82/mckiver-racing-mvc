using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MckiverRacing.MVC.Data;

namespace MckiverRacing.MVC.Services
{
   public interface IGuestBookServices
    {
       Boolean Post(GuestBookContact guestbookcontact);
       IList<GuestBookContact> GetPostings();
       GuestBookContact GetPostingById(int id);

    }
}
