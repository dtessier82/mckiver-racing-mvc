using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MckiverRacing.MVC.Data;

namespace MckiverRacing.MVC.Services
{
    public interface IEmailService
    {
        Boolean Send(EmailMessage _mail);
    }
}
