using AcunmedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class SkillController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();
        public ActionResult SkillList()
        {
            var values = db.TableSkillD.ToList();
            return View(values);
        }
        [HttpGet]

        public ActionResult CreateSkill()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateSkill(TableSkillD skillD)
        {
            db.TableSkillD.Add(skillD);
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }
        public ActionResult DeleteSkill(int id)
        {
            var value = db.TableSkillD.Find(id);
            db.TableSkillD.Remove(value);
            db.SaveChanges();
            return RedirectToAction("SkillList");


        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.TableSkillD.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSkill(TableSkillD p)
        {
            var value = db.TableSkillD.Find(p.Skilld);
            value.SkillTitle = p.SkillTitle;
            value.SkillValue = p.SkillValue;           
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}