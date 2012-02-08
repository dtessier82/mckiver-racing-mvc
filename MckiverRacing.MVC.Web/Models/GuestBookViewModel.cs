using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MckiverRacing.MVC.Web.Models
{
    public class GuestBookViewModel : BaseViewModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your Name")]
        [StringLength(50,ErrorMessage="Name cannot exceed more than 50 characters")]
        [DisplayName("Name")]
        public string Contact_Name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your email")]
        [StringLength(100, ErrorMessage = "Name cannot exceed more than 100 characters")]
        [DisplayName("Email")]
        public string Contact_Email { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your Comment")]
        [StringLength(250, ErrorMessage = "Name cannot exceed more than 250 characters")]
        [DisplayName("Comment")]
        public string Comment { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Date Posted")]
        public DateTime Date_Entered { get; set; }
    }
}