using AcunmedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class ServicesController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();
        public ActionResult ServicesList()
        {
            var values = db.TblService.ToList();
            return View(values);
        }
        [HttpGet]

        public ActionResult CreateServices()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateServices(TblService service)
        {
            db.TblService.Add(service);
            db.SaveChanges();
            return RedirectToAction("ServicesList");
        }
        public ActionResult DeleteServices(int id)
        {
            var value = db.TblService.Find(id);
            db.TblService.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ServicesList");


        }
        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var value = db.TblService.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateServices(TblService p)
        {
            var value = db.TblService.Find(p.ServiceId);
            value.ServiceTitle = p.ServiceTitle;
            value.Description = p.Description;
            value.IconUrl = p.IconUrl;
            db.SaveChanges();
            return RedirectToAction("ServicesList");
        }
    }
}