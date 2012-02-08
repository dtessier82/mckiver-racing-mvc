using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MckiverRacing.MVC.Web.Models;
using MckiverRacing.MVC.Data;
using MckiverRacing.MVC.Services;
using MvcReCaptcha;

namespace MckiverRacing.MVC.Web.Controllers
{
    public class GuestBookController : Controller
    {

        IGuestBookServices _gbServices = null;

        public GuestBookController(){

            _gbServices = new GuestBookServices();
        }
        //
        // GET: /GuestBook/

        public ActionResult Index()
        {
            ViewData["Selected"] = "ContactUs";

            IList<GuestBookContact> _gbContactList =
                _gbServices.GetPostings();


            return View(MapToViewModel(_gbContactList.ToList()));
        }

       

        //
        // POST: /GuestBook/Create

        public ActionResult Sign()
        {
            ViewData["Selected"] = "ContactUs";
            return View();
        }

        [HttpPost]
        [CaptchaValidator] 
        public ActionResult Sign(GuestBookViewModel model, bool captchaValid)
        {
            ViewData["Selected"] = "ContactUs";
            if(ModelState.IsValid){

                if (captchaValid)
                {
                    //BIND GuestBookViewModel to DataObject
                    //NEED TO IMPLEMENT PROPER ORM IN FUTURE!
                    GuestBookContact contact = new GuestBookContact();
                    contact.Contact_Email = model.Contact_Email;
                    contact.Contact_Name = model.Contact_Name;
                    contact.Comment = model.Comment;

                    if (_gbServices.Post(contact))
                        return RedirectToAction("Index");
                    else
                    {

                        ViewData["ErrorMessage"] = "An error occured while posting your comment. Please try again.";
                        return View();
                    }

                }
                else
                {
                    ViewData["ErrorMessage"] = "You did not type the verification word correctly. Please try again.";
                    return View();
                }
                
                
            }
            else{

                return View();
            }
        }
        
        //
        // GET: /GuestBook/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /GuestBook/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /GuestBook/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /GuestBook/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private List<GuestBookViewModel> MapToViewModel(List<GuestBookContact> _list){

            List<GuestBookViewModel> gbList = new List<GuestBookViewModel>();

            foreach(GuestBookContact g in _list){

                gbList.Add(new GuestBookViewModel
                {
                    Comment = g.Comment,
                    Contact_Name = g.Contact_Name,
                    Contact_Email = g.Contact_Email,
                    Date_Entered=g.Date_Entered
                });
            }

            return gbList;
        }
    }
}
