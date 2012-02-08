using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MckiverRacing.MVC.Web.Models
{
    public class BaseViewModel
    {
       
        public int ID { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Description")]
        public string Description { get; set; }
    }
}