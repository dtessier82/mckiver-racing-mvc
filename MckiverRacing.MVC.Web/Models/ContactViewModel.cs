using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MckiverRacing.MVC.Data;
using MckiverRacing.MVC.Data.Utilities;

namespace MckiverRacing.MVC.Web.Models
{
    public enum ContactUsTypes
    {
        [EnumDisplayName("Sponsorship")]
        Sponsorship = 1,

        [EnumDisplayName("General Inquiries")]
        General = 2,

    }

    public class ContactViewModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage="Please enter your name")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your email")]
        [DisplayName("Email")]
        public string Email { get; set; }

        //[DataType(DataType.Text)]
        //[Required(ErrorMessage = "Please enter the subject of your request")]
        //[DisplayName("Subject")]
        //public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter your name")]
        [DisplayName("Comment")]
        public string Comment { get; set; }

        [Required(ErrorMessage= "Please select the type of request.")]
        [DisplayName("Type Of Inquiry")]
        public ContactUsTypes Type {get;set;}

    }
}