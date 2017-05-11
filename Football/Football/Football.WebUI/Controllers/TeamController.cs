using Football.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Football.WebUI.Controllers
{
    public class TeamController : Controller
    {
        public ActionResult RequestTeams()
        {           
            return View();
        }

        // GET: Team
        public ActionResult ShowTeams()
        {
            var model = Repository.GetTeams();
                        
            return View(model.ToList());
        }
    }
}