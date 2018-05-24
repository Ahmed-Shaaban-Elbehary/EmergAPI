using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmergAPI.Models;
namespace EmergAPI.Controllers
{
    public class MapController : Controller
    {
        _dbContext db = new _dbContext();
        public MapController()
        {
            db = new _dbContext();
        }
        
        // GET: Map/Map
        public ActionResult Map()
        {
            return View();
        }
        public JsonResult GETEvent()
        {
            //var data = db.Events.ToList();
            var data = db.Events.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);

        }

        //---------Police---------------
        public ActionResult Police()
        {
            return View();
        }
        //------------AJAX CALL---------
        //public JsonResult Getpolice()
        //{
        //    //var query = from e in db.Events
        //    //            //where e.EventType == EventType.Police
        //    //            select e;

        //    //return Json(query, JsonRequestBehavior.AllowGet);

        //}

        //-------------Embulance------------
        public ActionResult Embulance()
        {
            return View();
        }
        //------------AJAX CALL---------
        //public JsonResult GetEmbulance()
        //{
        //    ////var data = db.Events.ToList();
        //    //var query = from e in db.Events
        //    //            //where e.EventType == EventType.Embulance
        //    //            select e;
        //    //return Json(query, JsonRequestBehavior.AllowGet);

        //}

        //-------------Fire------------
        public ActionResult Blaze()
        {
            return View();
        }
        //------------AJAX CALL---------
        //public JsonResult GetFire()
        //{
        //    ////var data = db.Events.ToList();
        //    //var query = from e in db.Events
        //    //            where e.EventType == EventType.blaze
        //    //            select e;
        //    //return Json(query, JsonRequestBehavior.AllowGet);

        //}
    }
} 