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
        


        //---------Police---------------
        public ActionResult Police()
        {
            return View();
        }
        //------------AJAX CALL---------
        public JsonResult Getpolice()
        {
            var query = db.Events.Where(e => e.EventType == EventType.Police);
            return Json(query, JsonRequestBehavior.AllowGet);
           

        }
        //------------AJAX CALL---------
        public JsonResult GetpoliceById(int ID)
        {
            var query = db.Events.Where(e => e.Id == ID);
            return Json(query, JsonRequestBehavior.AllowGet);
        }
        //-------------Embulance------------
        public ActionResult Embulance()
        {
            return View();
        }
        //------------AJAX CALL---------
        public JsonResult GetEmbulance()
        {
            var query = db.Events.Where(e => e.EventType == EventType.Embulance);

            return Json(query, JsonRequestBehavior.AllowGet);                                                
        }
        [HttpGet]
        public JsonResult GetEmbulanceById(int ID)
        {
            var query = db.Events.Where(e => e.EventType == EventType.Police);
            return Json(query, JsonRequestBehavior.AllowGet);
        }
        //-------------Fire------------
        public ActionResult Fire()
        {
            return View();
        }
        //------------AJAX CALL---------
        public JsonResult GetFire()
        {

            var query = db.Events.Where(e => e.EventType == EventType.Fire);
            return Json(query, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public JsonResult GetFireById(int ID)
        {
            var query = db.Events.Where(e => e.EventType == EventType.Police);
            return Json(query, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ComingEvents()
        {
            return View();
        }

    }
} 