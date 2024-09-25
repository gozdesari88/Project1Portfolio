using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio.Controllers
{
    public class EdducationController : Controller
    {
        // GET: Edducation
        public ActionResult EdducationList()
        {
            return View();
        }
        public ActionResult CreateEducation()
        {
        return View();  
        }

    }
}