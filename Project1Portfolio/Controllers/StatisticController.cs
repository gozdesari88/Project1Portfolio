using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio.Controllers
{
    public class StatisticController : Controller
    {
      MyPortfolyoDbEntities3 context = new MyPortfolyoDbEntities3();    
        public ActionResult Index()
        {
            int messageCount = context.Message.Count();
            int messageCountIsReadByTrue=context.Message.Where(x=>x.IsRead==true).Count();
            int messageCountIsReadByFalse=context.Message.Where(x=>x.IsRead==false).Count();
            int skillCount=context.Skill.Count();
            var totalSkillValue=context.Skill.Sum(x=>x.Value);
            var averageSkillValue=context.Skill.Average(x=>x.Value);
            var getEmailProfile=context.Profile.Select(x=>x.Email).FirstOrDefault();
            var getLastCategoryId=context.Category.Max(x=>x.CategoryId);
            var getLastCategoryName=context.Category.Where(x=>x.CategoryId==getLastCategoryId).Select(y=>y.CategoryName).FirstOrDefault();

            ViewBag.messageCount = messageCount;
            ViewBag.messageCountIsReadByTrue = messageCountIsReadByTrue;
            ViewBag.messageCountIsReadByFalse = messageCountIsReadByFalse;
            ViewBag.skillCount = skillCount;
            ViewBag.totalSkillValue = totalSkillValue;
            ViewBag.averageSkillValue = averageSkillValue;
            ViewBag.getEmailProfile = getEmailProfile;
            ViewBag.getLastCategoryName = getLastCategoryName;


            return View();
        }
    }            
}