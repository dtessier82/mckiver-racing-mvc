using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MckiverRacing.MVC.Web.Models;
using MckiverRacing.MVC.Services;
using MckiverRacing.MVC.Data;
using MckiverRacing.MVC.Data.Utilities;
using System.Net.Configuration;
using System.Text;

namespace MckiverRacing.MVC.Web.Controllers
{
    public class ContactUsController : Controller
    {
        //
        // GET: /ContactUs/
        IEmailService _emailService;

        public ContactUsController(){

            _emailService = new EmailService();
        }

        void SetSelectList(){
            var allEnums = Array.ConvertAll(Enum.GetNames(typeof(ContactUsTypes)),
                          s => new { id = s, Name = s.ToString() });
            ViewData["ContactTypes"] = new SelectList(allEnums, "id", "Name");

        }


        public ActionResult Index()
        {
            SetSelectList();
            ViewData["Selected"] = "ContactUs";
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactViewModel model){

            SetSelectList();
            ViewData["Selected"] = "ContactUs";
            if(ModelState.IsValid){

                EmailMessage _mail = new EmailMessage();
                _mail.SMTPSettings = (SmtpSection)ConfigKeys.GetConfigSection("system.net/mailSettings/smtp");

                if (model.Type == ContactUsTypes.General){
                    _mail.To = ConfigKeys.GetConfigValue("GeneralEmail");
                    _mail.Subject = "General Inquires";
                }
                else if(model.Type == ContactUsTypes.Sponsorship){
                    _mail.To = ConfigKeys.GetConfigValue("SponsorshipEmail");
                    _mail.Subject = "Sponsorship Inquires";
                }
                _mail.From = model.Email;
                _mail.FromDisplayName = model.Name;
                _mail.MessageBody = model.Comment;
                

                if(_emailService.Send(_mail))
                    ViewData["Message"] = "Thanks!";
                else
                    ViewData["Message"] = "Sorry your message could not be sent please try again!";
     
                
            }
            else{

                ModelState.AddModelError("", "Please enter all the required fields.");
            }

            return View("Index", model);
            
        }

    }
}
