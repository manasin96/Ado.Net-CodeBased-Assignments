using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballCodebased.Models;

namespace FootballCodebased.Controllers
{
    public class HomeController : Controller
    {
        FootballContext context = new FootballContext();
        public ActionResult Index()
        {
            return View(context.FootBalls);
        }

        public ActionResult AddResult()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveResult(Football ft)
        {
            context.FootBalls.Add(ft);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}