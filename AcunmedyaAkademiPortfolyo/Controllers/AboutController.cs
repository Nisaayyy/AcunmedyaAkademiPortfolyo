using AcunmedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class AboutController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();
        public ActionResult AboutList()
        {
            var values = db.TblAboutID.ToList();
            return View(values);
        }
        [HttpGet]

        public ActionResult CreateAbout()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateAbout(TblAboutID aboutID)
        {
            db.TblAboutID.Add(aboutID);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public ActionResult DeleteAbout(int id)
        {
            var value = db.TblAboutID.Find(id);
            db.TblAboutID.Remove(value);
            db.SaveChanges();
            return RedirectToAction("AboutList");


        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = db.TblAboutID.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(TblAboutID p)
        {
            var value = db.TblAboutID.Find(p.AboutID);
            value.AboutBirthday = p.AboutBirthday;
            value.AboutCity = p.AboutCity;
            value.AboutEmail = p.AboutEmail;
            value.AboutEğitim = p.AboutEğitim;
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }




    }
}