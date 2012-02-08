using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MckiverRacing.MVC.Data
{
    public class GuestBookContact : BaseModel 
    {
        public string Contact_Name { get; set; }
        public string Contact_Email { get; set; }
        public string Comment { get; set; }
        public DateTime Date_Entered { get; set; }
    }
}
