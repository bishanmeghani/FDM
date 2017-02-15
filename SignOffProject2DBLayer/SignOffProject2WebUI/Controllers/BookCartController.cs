using SignOffProject2DBLayer;
using SignOffProject2Logic;
using SignOffProject2WebUI.Models;
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
            BookCartViewModels viewModel;
            viewModel = CreateBookCartViewModel();
            return View("BookCart", viewModel);
        }

        [HttpPost]
        public ActionResult AddToCart()
        {
            Book bookAdded = new Book();
            bookLogic = new BookLogic();
            bookLogic.AddToCart(bookAdded);
            return RedirectToAction("Index", "Home");
        }

        //Create view model for one group
        public BookCartViewModels CreateBookCartViewModel()
        {
            BookCartViewModels model = new BookCartViewModels();
            var groupList = _userAccountLogic.ViewAllGroupsFollowedByUser(user).Where(u => u.groupID == id);

            List<GroupViewModels> groups = new List<GroupViewModels>();

            foreach (Group g in groupList)
            {
                groups.Add(new GroupViewModels() { group = g });
            }

            var group = groups.First();

            return group;
        }
    }
}