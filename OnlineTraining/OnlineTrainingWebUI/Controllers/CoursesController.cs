using OnlineTraining.EntityFramework;
using OnlineTraining.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineTrainingWebUI.Controllers
{
    public class CoursesController : Controller
    {
        OnlineTrainingModel modeldb = new OnlineTrainingModel();
        ShoppingCartLogic cartlogic;

        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.RatingSortParm = sortOrder == "Rating" ? "rating_desc" : "Rating";
            ViewBag.DurationSortParm = sortOrder == "Duration" ? "duration_desc" : "Duration";
            ViewBag.PriceSortParm = sortOrder == "Course Price" ? "price_desc" : "Course Price";
            var cs = from c in modeldb.courses select c;
            
            if (!String.IsNullOrEmpty(searchString))
            {
                cs = cs.Where(c => c.courseName.Contains(searchString));
            }

            switch(sortOrder)
            {
                case "name_desc":
                    cs = cs.OrderByDescending(c => c.courseName);
                    break;
                case "Rating":
                    cs = cs.OrderBy(c => c.courseRating);
                    break;
                case "Duration":
                    cs = cs.OrderBy(c => c.courseDurationHours);
                    break;
                case "Course Price":
                    cs = cs.OrderBy(c => c.coursePrice);
                    break;
                case "rating_desc":
                    cs = cs.OrderByDescending(c => c.courseRating);
                    break;
                case "duration_desc":
                    cs = cs.OrderByDescending(c => c.courseDurationHours);
                    break;
                case "price_desc":
                    cs = cs.OrderByDescending(c => c.coursePrice);
                    break;
                default:
                    cs = cs.OrderBy(c => c.courseName);
                    break;
            }
            return View(cs.ToList());
        }

        public ActionResult Overview()
        {
            return View();
        }

        public ActionResult AddCourseToCart(CartItem courseToPutInCart)
        {
            cartlogic = new ShoppingCartLogic();

            //Customers customerToDelete = modeldb.customers.Where(c => c.customerEmail == User.Identity.Name).ToList()[0];

            cartlogic.AddToCart(courseToPutInCart);
            return RedirectToAction("Cart", "Account");
        }

    }
}