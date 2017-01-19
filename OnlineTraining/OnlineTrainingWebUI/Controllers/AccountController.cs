using OnlineTraining.EntityFramework;
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

        [HttpPost]
        public ActionResult Login(Customers customerToLogin)
        {
            //If Email and password match, you are logged in
            Reposit repository = new Reposit(modeldb);
            if (repository.CheckIfUserHasAnAccount(customerToLogin.customerEmail) == true && repository.CheckUserPassword(customerToLogin.customerPassword) == true) 
            {                
                if (Request.IsAjaxRequest())
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            if (repository.CheckIfUserHasAnAccount(customerToLogin.customerEmail) == false)
            {
                return PartialView("_UnsuccessfulLoginEmail");
            }
            if (repository.CheckIfUserHasAnAccount(customerToLogin.customerEmail) == true && repository.CheckUserPassword(customerToLogin.customerPassword) == false)
            {
                return PartialView("_UnsuccessfulLoginPassword");
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
            Reposit repository = new Reposit(modeldb);
            repository.AddCustomer(customerToRegister);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_SuccessRegister", "Home");
            }

            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

      
        
    }  
}