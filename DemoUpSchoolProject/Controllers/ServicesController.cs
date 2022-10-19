using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoUpSchoolProject.Models.Entities;


namespace DemoUpSchoolProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        /*
        ToList
        Add
        Remove
        Where     
         */
        UpSchoolDbPortfolioEntities db = new UpSchoolDbPortfolioEntities();
        public ActionResult Index()
        {
         var values= db.TblServices.ToList();


            return View(values);
        }
        [HttpGet]
        public ActionResult AddServices()
        {

            return View();

        }
        [HttpPost]
            public ActionResult AddServices(TblServices p)
        {
            db.TblServices.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");


        }


        public ActionResult DeleteService(int id)
        {
            var values = db.TblServices.Find(id);
            db.TblServices.Remove(values);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}