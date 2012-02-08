using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MckiverRacing.MVC.Data
{
    public class News : BaseModel
    {
        
        public string News_Title { get; set; }
        public string News_Schort_Description { get; set; }
        public DateTime Created_Date { get; set; }

    }
}
