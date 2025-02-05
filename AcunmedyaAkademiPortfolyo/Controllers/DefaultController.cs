using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolyo.Models;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();

        






        public PartialViewResult PartialStatistic()
        {
            var values = db.TblStatistic.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSocialMedia()
        { 
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblAboutID.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMessage()
        {
            var values = db.TblMessage.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonials()
        {
            var values = db.TableTestimonial.ToList();
            return PartialView(values);
        }


        public PartialViewResult PartialServices()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialProject()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialEducation()
        {
            var values = db.TblEducation.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialExperience()
        {
            var values = db.TblExperience.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.TableSkillD.ToList();
            return PartialView(values);
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead() 
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeroSection()
        {
            return PartialView();
        }
       
        
    }
}