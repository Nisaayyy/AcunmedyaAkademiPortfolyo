using AcunmedyaAkademiPortfolyo.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class TestimonialController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();

        //GET : Testimonial
        public ActionResult TestimonialList()
        {
            var values = db.TableTestimonial.ToList();
            return View(values);
        }

        [HttpGet]

        public ActionResult CreateTestimonial()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateTestimonial(TableTestimonial testimonial)
        {
            db.TableTestimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.TableTestimonial.Find(id);
            db.TableTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");

        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int? id)
        {
            var value = db.TableTestimonial.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(TableTestimonial p)
        {
                 
            var value = db.TableTestimonial.Find(p.Testimoniald);
                       
            
            value.Testimoniald = p.Testimoniald;
            value.NameSurname = p.NameSurname;
            value.Title = p.Title;
            value.CommentDetail = p.CommentDetail;
            value.ImageUrl = p.ImageUrl;           
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }


    }
}