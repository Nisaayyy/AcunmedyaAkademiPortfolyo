using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolyo.Models;
using Newtonsoft.Json.Linq;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class CategoryController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();
        public ActionResult CategoryList()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }
        [HttpGet]

        public ActionResult CreateCategory()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateCategory(TblCategory category)
        {
            db.TblCategory.Add(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public ActionResult DeleteCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            db.TblCategory.Remove(value);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
       
            
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TblCategory p)
        {
            var value = db.TblCategory.Find(p.Categoryld);
            value.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }







    }
}