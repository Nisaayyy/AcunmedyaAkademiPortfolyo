using AcunmedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class ProjectController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();
        public ActionResult ProjectList()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }
        [HttpGet]

        public ActionResult CreateProject()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateProject(TblProject project)
        {
            db.TblProject.Add(project);
            db.SaveChanges();
            return RedirectToAction("Project");
        }
        public ActionResult DeleteProject(int id)
        {
            var value = db.TblProject.Find(id);
            db.TblProject.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ProjectList");


        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = db.TblProject.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProject(TblProject p)
        {
            var value = db.TblProject.Find(p.Projectld);
            value.ProjectTitle = p.ProjectTitle;
            value.Description = p.Description;
            value.ImageUrl = p.ImageUrl;
            value.CategoryId = p.CategoryId;

            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }
    }
}