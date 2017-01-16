using OnlineTraining.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineTrainingWebUI.Controllers
{
    public class CoursesController : Controller
    {
        OnlineTrainingModel db = new OnlineTrainingModel();
        // GET: Books
        public ActionResult Index()
        {
            return View(db.courses.ToList());
        }
    }
}