using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MckiverRacing.MVC.Data.Models;

namespace MckiverRacing.MVC.Data.DataAccess
{
    public interface IUserRepository
    {
        User LogIn(string username, string password);
        void SaveUser(User u);
        void ChangePassword(User u);
    }
}
