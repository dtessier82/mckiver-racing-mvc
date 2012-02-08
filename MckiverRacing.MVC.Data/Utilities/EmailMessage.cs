using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Configuration;

namespace MckiverRacing.MVC.Data
{
    public class EmailMessage
    {
        //public string SMTPServer { get; set; }
        //public string SMTPUserName { get; set; }
        //public string SMTPPassword { get; set; }
        //public Boolean EnableSSL { get; set; }
        //public string SMTPPort { get; set; }

        public string MessageBody { get; set; }
        public string Subject { get; set; }
        public string To { get; set; }
        public string ToDisplayName { get; set; }
        public string From { get; set; }
        public string FromDisplayName { get; set; }
        public SmtpSection SMTPSettings { get; set; }


    }
}
