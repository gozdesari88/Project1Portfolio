﻿using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Project1Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolyoDbEntities3 context = new MyPortfolyoDbEntities3();
        // GET: Experience
        public ActionResult ExperienceList()
        {
            var values = context.Experience.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateExperience()
        {
         return View();
        }
        [HttpPost]
        public ActionResult CreateExperience(Experience experience)
        {
            context.Experience.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");

        }
        public ActionResult DeleteExperience(int id)
        {
            var value=context.Experience.Find(id);
            context.Experience.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");

        }
        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var value= context.Experience.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult UpdateExperience(Experience experience)
        {
            var value = context.Experience.Find(experience.Experienceİd);
            value.Tittle = experience.Tittle;
            value.Description = experience.Description;
            value.WorkDate = experience.WorkDate;
            value.CompanyName= experience.CompanyName;
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

    }
}