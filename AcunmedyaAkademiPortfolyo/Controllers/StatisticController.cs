using AcunmedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolyo.Controllers
{
    public class StatisticController : Controller
    {
        DBacunmedyaakademi1Entities5 db = new DBacunmedyaakademi1Entities5();
        public ActionResult StatisticList()
        {
            var values = db.TblStatistic.ToList();
            return View(values);
        }
        [HttpGet]

        public ActionResult CreateStatistic()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateStatistic(TblStatistic statistic)
        {
            db.TblStatistic.Add(statistic);
            db.SaveChanges();
            return RedirectToAction("StatisticList");
        }
        public ActionResult DeleteStatistic(int id)
        {
            var value = db.TblStatistic.Find(id);
            db.TblStatistic.Remove(value);
            db.SaveChanges();
            return RedirectToAction("StatisticList");


        }
        [HttpGet]
        public ActionResult UpdateStatistic(int id)
        {
            var value = db.TblStatistic.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateStatistic(TblStatistic p)
        {
            var value = db.TblStatistic.Find(p.StatisticsId);
            value.StatsName = p.StatsName;
            value.StatsNumber = p.StatsNumber;
            value.StatsEmoji = p.StatsEmoji;
            db.SaveChanges();
            return RedirectToAction("StatisticList");
        }
    }
}