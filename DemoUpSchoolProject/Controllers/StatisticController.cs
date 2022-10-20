using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoUpSchoolProject.Models.Entities;
namespace DemoUpSchoolProject.Controllers
{
    public class StatisticController : Controller
    {
        UpSchoolDbPortfolioEntities db = new UpSchoolDbPortfolioEntities();

        public ActionResult Index()
        {
            // Referansların Toplam Sayısı
            ViewBag.v1 = db.TblTestimonial.Count();

            // İstanbul'daki Referans Sayısı 
            ViewBag.v2 = db.TblTestimonial.Where(x => x.City == "İstanbul").Count();

            //Yazılım Mühendisi Haricindeki Kişi Sayısı

            ViewBag.v3= db.TblTestimonial.Where(x => x.Profession!="Yazılım Mühendisi").Count();

            //Şehri Trabzon olan Kişinin İsmi
            ViewBag.v4 = db.TblTestimonial.Where(x => x.City == "Trabzon").Select(x => x.NameSurname).FirstOrDefault();

            //Referansların Ortalama
            ViewBag.v5 = db.TblTestimonial.Average(x => x.Balance);

            return View();
        }
    }
}