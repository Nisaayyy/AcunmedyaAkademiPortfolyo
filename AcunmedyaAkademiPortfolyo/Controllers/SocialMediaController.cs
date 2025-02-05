using AcunmedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class SocialMediaController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();
        public ActionResult SocialMediaList()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }
        [HttpGet]

        public ActionResult CreateSocialMedia()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateSocialMedia(TblSocialMedia socialMedia)
        {
            db.TblSocialMedia.Add(socialMedia);
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(value);
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");


        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia p)
        {
            var value = db.TblSocialMedia.Find(p.SocialMediaID);
            value.Instagram = p.Instagram;
            value.Twitter = p.Twitter;
            value.Facebook = p.Facebook;
            value.Linkedin = p.Linkedin;
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}