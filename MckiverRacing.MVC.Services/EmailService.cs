using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MckiverRacing.MVC.Data;
using System.Net.Mail;
using System.Net;
using System.Net.Configuration;

namespace MckiverRacing.MVC.Services
{
    public  class EmailService: IEmailService
    {
       
        public Boolean Send(EmailMessage _mail){

            
            Boolean flag = false;
            MailMessage oMail = new MailMessage();

            oMail.From = new MailAddress(_mail.From, _mail.FromDisplayName);

            oMail.To.Add(_mail.To);

            oMail.Subject = _mail.Subject;

            oMail.IsBodyHtml = true; // enumeration

            oMail.Priority = MailPriority.High; // enumeration

            oMail.Body = _mail.MessageBody;

            SmtpClient client = new SmtpClient();
            client.Host = _mail.SMTPSettings.Network.Host;
            client.EnableSsl = _mail.SMTPSettings.Network.EnableSsl;
            client.Port = _mail.SMTPSettings.Network.Port;
            client.Credentials = 
                new NetworkCredential(_mail.SMTPSettings.Network.UserName, _mail.SMTPSettings.Network.Password);


            try{

                client.Send(oMail);
                flag = true;
            }
            catch{}

            return flag;
        }
    }
}
