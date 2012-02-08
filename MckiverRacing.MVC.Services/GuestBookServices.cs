using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MckiverRacing.MVC.Data;
using MckiverRacing.MVC.Data.DataAccess;

namespace MckiverRacing.MVC.Services
{
    public class GuestBookServices : IGuestBookServices
    {
        IGuestBookRepository _gbRepo;

        public GuestBookServices(){

            _gbRepo = new SqlGuestBookRepository();
        }

        public Boolean Post(GuestBookContact guestbookcontact)
        {
            return _gbRepo.Post(guestbookcontact);
        }

        public IList<GuestBookContact> GetPostings() {

            return _gbRepo.GetPostings();
        }
        public GuestBookContact GetPostingById(int id) { throw new Exception("NOT IMPLEMENTATED"); }
    
    }
}
