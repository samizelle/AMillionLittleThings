using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMillionLittleThings.Controllers
{
    public class ThingController : Controller
    {
        // GET: Thing
        public ActionResult Index()
        {
            return View();
        }
    }
}