using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MckiverRacing.MVC.Data
{
    public class Race_Schedule : BaseModel
    {

        public int Schedule_Year { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public Race_Series Series { get; set; }
        public Race_Track Track { get; set; }
    }
}
