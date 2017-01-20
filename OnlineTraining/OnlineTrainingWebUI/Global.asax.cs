using OnlineTraining.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace OnlineTrainingWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            if (FormsAuthentication.CookiesSupported == true)
            {
                if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
                {
                    try
                    {
                        //let us take out the username now                
                        string email = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name;
                        string[] roles = new string[1];

                        using (OnlineTrainingModel olm = new OnlineTrainingModel())
                        {
                            Customers user = olm.customers.SingleOrDefault(u => u.customerEmail == email);

                            if (user.customerAdmin == 1)
                            {
                                roles[0] = "Admin";
                            }
                            else
                            {
                                roles[0] = "User";
                            }

                        }
                        //let us extract the roles from our own custom cookie


                        //Let us set the Pricipal with our user specific details
                        HttpContext.Current.User = new System.Security.Principal.GenericPrincipal(
                  new System.Security.Principal.GenericIdentity(email, "Forms"), roles);

                    }
                    catch (Exception)
                    {
                        //somehting went wrong
                    }
                }
            }
        }
    }
}
