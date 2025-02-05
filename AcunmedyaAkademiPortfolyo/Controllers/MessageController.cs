using AcunmedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class MessageController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();
        public ActionResult MessageList()
        {
            var values = db.TblMessage.ToList();
            return View(values);
        }
        [HttpGet]

        public ActionResult CreateMessage()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateMessage(TblMessage message)
        {
            db.TblMessage.Add(message);
            db.SaveChanges();
            return RedirectToAction("MessageList");
        }
        public ActionResult DeleteMessage(int id)
        {
            var value = db.TblMessage.Find(id);
            db.TblMessage.Remove(value);
            db.SaveChanges();
            return RedirectToAction("MessageList");


        }
        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var value = db.TblMessage.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateMessage(TblMessage p)
        {
            var value = db.TblMessage.Find(p.MessageId);
            value.MesTitle = p.MesTitle;
            value.MesDescription = p.MesDescription;
            value.MesIcon = p.MesIcon;
            db.SaveChanges();
            return RedirectToAction("MessageList");
        }
    }
}