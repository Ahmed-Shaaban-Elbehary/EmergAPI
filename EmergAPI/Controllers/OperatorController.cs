using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmergAPI.Controllers
{
    public class OperatorController : Controller
    {
        _dbContext db = new _dbContext();

        //------------------
        //Operators CRUDs
        //------------------

        // GET: Operator
        public ActionResult Index()
        {
            var operators = db.Operators.ToList();
            return View(operators);
        }
        // GET: Operator/Create
        public ActionResult CreateOperator()
        {
            return View();
        }
        // POST: Operator/Create
        [HttpPost]
        public ActionResult CreateOperator(Operator ope)
        {
            if (ModelState.IsValid)
            {
                db.Operators.Add(ope);
                db.SaveChanges();
                return View();
            }
            return View();
        }

        public ActionResult EditOperator()
        {
            return View();
        }

        // UPDATE: Operator/Create
        [HttpPut]
        public ActionResult EditOperator(int id,Operator ope)
        {
            if (ModelState.IsValid)
            {
                var operatorsInDb = db.Operators.SingleOrDefault(e => e.Id == id);

                if (operatorsInDb != null)
                {
                    operatorsInDb.Name = ope.Name;
                    operatorsInDb.Password = ope.Password;
                    operatorsInDb.ConfirmPassword = ope.ConfirmPassword;
                    operatorsInDb.IdentificationNumber = ope.IdentificationNumber;
                    operatorsInDb.MobilePhone = ope.MobilePhone;
                    operatorsInDb.Birthdate = ope.Birthdate;
                    operatorsInDb.Hiredate = ope.Hiredate;
                    operatorsInDb.Salary = ope.Salary;
                    operatorsInDb.Gender = ope.Gender;
                    operatorsInDb.IsAdmin = ope.IsAdmin;

                    db.SaveChanges();
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        // DELETE: Operator/Create
        [HttpDelete]
        public ActionResult DeleteOperator(int id)
        {
            var operators = db.Operators.SingleOrDefault(e => e.Id == id);
            
            db.Operators.Remove(operators);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
