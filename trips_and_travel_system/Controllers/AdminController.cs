using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trips_and_travel_system.Models;

namespace trips_and_travel_system.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult Posts()
        {
            return View();
        }
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult PostsRequests()
        {
            return View();
        }
    }
}