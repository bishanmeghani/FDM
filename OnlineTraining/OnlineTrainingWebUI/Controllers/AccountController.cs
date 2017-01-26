using OnlineTraining.EntityFramework;
using OnlineTraining.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineTrainingWebUI.Controllers
{
    public class AccountController : Controller
    {
        OnlineTrainingModel modeldb = new OnlineTrainingModel();
        CustomerLogic clogic;
        ShoppingCartLogic cartlogic;

        [HttpPost]
        public ActionResult Login(Customers customerToLogin, string returnUrl)
        {
            // Lets first check if the Model is valid or not
            if (ModelState.IsValid)
            {
                clogic = new CustomerLogic(modeldb);
                string customerEmail = customerToLogin.customerEmail;
                string customerPassword = customerToLogin.customerPassword;

                // Now if our password was enctypted or hashed we would have done the
                // same operation on the user entered password here, But for now
                // since the password is in plain text lets just authenticate directly

                if (clogic.CustomerLogin(customerToLogin) == 1)
                {
                    FormsAuthentication.SetAuthCookie(customerEmail, false);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else if (clogic.CustomerLogin(customerToLogin) == 2)
                {
                    if (Request.IsAjaxRequest())
                    {
                        return PartialView("_UnsuccessfulLoginEmail");
                    }
                }
                else if (clogic.CustomerLogin(customerToLogin) == 3)
                {
                    if (Request.IsAjaxRequest())
                    {
                        return PartialView("_UnsuccessfulLoginPassword");
                    }

                }
            }

            // If we got this far, something failed, redisplay form
            return View(customerToLogin);
        }  
        
        [HttpPost]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult DeleteMyAccount()
        {
            clogic = new CustomerLogic(modeldb);

            Customers customerToDelete = modeldb.customers.Where(c => c.customerEmail == User.Identity.Name).ToList()[0];

            clogic.RemoveAccount(customerToDelete);
            return RedirectToAction("Index", "Home");
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
            return View("Login");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View("Register");
        }

        //[HttpGet]
        //public ActionResult Cart()
        //{
        //    cartlogic = new ShoppingCartLogic();
        //    //cartlogic.AddToCart(new CartItem { ProductName = "maths" });

            
        //    return View(cartlogic.GetAllItems());
        //}
    }  
}