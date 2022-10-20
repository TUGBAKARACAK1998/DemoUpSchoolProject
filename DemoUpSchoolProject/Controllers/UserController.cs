using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoUpSchoolProject.Controllers
{
    public class UserController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Head()
        {
            return PartialView();
        }
        public PartialViewResult Header()
        {
            return PartialView();
        }
        public PartialViewResult DomainModal()
        {
            return PartialView();
        }

        public PartialViewResult SocialMedia()
        {
            return PartialView();
        }

        public PartialViewResult Skills()
        {
            return PartialView();
        }


        public PartialViewResult FeaturedSkills()
        {
            return PartialView();
        }


        public PartialViewResult Awards()
        {
            return PartialView();
        }



        public PartialViewResult Testimonial()
        {
            return PartialView();
        }


        public PartialViewResult Clients()
        {
            return PartialView();
        }


        public PartialViewResult Contact()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }
       
    }
}