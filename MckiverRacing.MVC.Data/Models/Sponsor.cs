using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MckiverRacing.MVC.Data
{
    public class Sponsor : BaseModel
	{

        public string Sponsor_Name { get; set; }
        public string Sponsor_Url { get; set; }
        public string Sponsor_Logo { get; set; }

	}
}
