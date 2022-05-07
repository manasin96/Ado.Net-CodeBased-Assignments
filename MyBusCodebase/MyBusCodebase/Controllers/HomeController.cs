using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBusCodebase.Models;


namespace MyBusCodebase.Controllers
{
    public class HomeController : Controller
    {
        BusinfoContext context = new BusinfoContext();
        public ActionResult Index()
        {
            return View(context.businfos);
        }

        public ActionResult AddBusDetail()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SaveBusDetail(BusinfoClass bus)
        {
            context.businfos.Add(bus);
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