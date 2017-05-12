using CitySearch.DataLayer;
using CitySearch.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CitySearch.WebUI.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        [HttpGet]
        public ActionResult Index()
        {                   
            return View();
        }

        [HttpPost]
        public ActionResult Index(string searchString)
        {
            CityFinder cf = new CityFinder();
            ICityResult cres = cf.Search(searchString);
            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialSearch", cres);
            }
            else
            {
                return View(cres);
            }
            
        }
    }
}