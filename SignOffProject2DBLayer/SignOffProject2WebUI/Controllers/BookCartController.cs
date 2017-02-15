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

        // GET: BookCart
        public ActionResult Index()
        {
            //Book bookAdded = modelDb.books.Where(b => b.title).ToList[0];
            bookLogic = new BookLogic();
            //bookLogic.AddToCart(bookAdded);
            return RedirectToAction("Index", "Home");
        }
    }
}