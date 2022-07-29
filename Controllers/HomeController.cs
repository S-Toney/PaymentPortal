using PPDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [HttpPost]
        public ActionResult TestErrorWriteToDB_Click(object sender, EventArgs e)
        {
            /* Testing the Error Writing to DB functionality */
            Exception ex = new Exception();
            DataLayer PSDL = new DataLayer();
            PSDL.ErrorMessageWriter(ex, "Testing Error writing connection to DB", "testing", $"{PSDL.ApplicationName} - Testing Error Writing Button");
            //throw;
            return RedirectToAction("Index");
        }
    }
}