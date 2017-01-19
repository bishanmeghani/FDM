using OnlineTraining.EntityFramework;
using OnlineTraining.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineTrainingWebUI.Controllers
{
    public class AccountController : Controller
    {
        OnlineTrainingModel modeldb = new OnlineTrainingModel();
        CustomerLogic clogic;

        [HttpPost]
        public ActionResult Login(Customers customerToLogin)
        {
            //If Email and password match, you are logged in
            clogic = new CustomerLogic(modeldb);
            
            if (clogic.CustomerLogin(customerToLogin) == 1)
            {
                if (Request.IsAjaxRequest())
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            if (clogic.CustomerLogin(customerToLogin) == 2)
            {
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_UnsuccessfulLoginEmail");
                }
            }

            if (clogic.CustomerLogin(customerToLogin) == 3)
            {
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_UnsuccessfulLoginPassword");
                }
            }
            return PartialView("_UnsuccessfulLogin");
        }
            
        
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(Customers customerToRegister)
        {
            //{ customerFirstName = "Daniel", customerLastName = "Mason", customerAddress = "34JohnLane-B28FR", customerPhone = "07975324634", customerEmail = "dan.mason@tiscali.com", customerpassword = "moonpie" };
            clogic = new CustomerLogic(modeldb);
            if(clogic.CustomerRegister(customerToRegister) == true)
            {
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_UnsuccessfulRegister", "Home");
                }
            }
            return PartialView("_SuccessRegister", "Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

      
        
    }  
}