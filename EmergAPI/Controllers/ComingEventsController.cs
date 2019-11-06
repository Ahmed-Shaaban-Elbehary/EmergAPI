using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmergAPI.Controllers
{
    public class ComingEventsController : Controller
    {
        // GET: ComingEvents
        public ActionResult Index()
        {
            return View();
        }
    }
}