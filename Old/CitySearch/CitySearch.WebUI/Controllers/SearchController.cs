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
        public ActionResult Index()
        {                        
            return View(Repository.GetCities());
        }

        public ActionResult SearchCity(string searchString)
        {
            CityFinder cf = new CityFinder();
            ICityResult cres = cf.Search(searchString);
            return View(cres.NextCities.ToList().ToString());
        }
    }
}