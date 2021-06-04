using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trips_and_travel_system.Models;

namespace trips_and_travel_system.Controllers
{
    public class AgencyController : Controller
    {
        public ActionResult Profile()
        {
            /*using(TripsAndTravelContext db = new TripsAndTravelContext())
            {
                db.RoleMasters.Add(new RoleMaster() { RoleName = "Admin"});
                db.SaveChanges();
            }*/
            return View();
        }
        public ActionResult CreateNewPost()
        {
            return View();
        }
        public ActionResult MyPosts()
        {
            return View();
        }
        public ActionResult ReceivedQuestions()
        {
            return View();
        }
    }
}