using SignOffProject2DBLayer;
using SignOffProject2Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignOffProject2WebUI.Controllers
{
    public class BookCartController : Controller
    {
        SignOffDBModel modelDb = new SignOffDBModel();
        BookLogic bookLogic;

        [HttpGet]
        public ActionResult Index()
        {
            return View("BookCart");
        }

        [HttpPost]
        public ActionResult AddToCart()
        {
            Book bookAdded = new Book();
            bookLogic = new BookLogic();
            bookLogic.AddToCart(bookAdded);
            return RedirectToAction("Index", "Home");
        }
    }
}