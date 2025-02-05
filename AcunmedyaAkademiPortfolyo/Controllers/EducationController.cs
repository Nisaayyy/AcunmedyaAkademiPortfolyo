using AcunmedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class EducationController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();
        public ActionResult EducationList()
        {
            var values = db.TblEducation.ToList();
            return View(values);
        }
        [HttpGet]

        public ActionResult CreateEducation()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateEducation(TblEducation education)
        {
            db.TblEducation.Add(education);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public ActionResult DeleteEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            db.TblEducation.Remove(value);
            db.SaveChanges();
            return RedirectToAction("EducationList");


        }
        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducation p)
        {
            var value = db.TblEducation.Find(p.Educationld);
            value.Title = p.Title;
            value.SubTitle = p.SubTitle;
            value.Period = p.Period;
            value.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}