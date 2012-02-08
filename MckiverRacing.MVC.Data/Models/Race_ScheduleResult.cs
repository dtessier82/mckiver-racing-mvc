using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MckiverRacing.MVC.Data
{
    public class Race_ScheduleResult : BaseModel
    {

        public decimal Qualify_Time { get; set; }

        public Int32 Qualify_Position { get; set; }

        public decimal Finish_Time { get; set; }

        public Int32 Finish_Position { get; set; }

        public Race_Class Class { get; set; }
    }
}
