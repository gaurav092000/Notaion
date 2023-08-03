using Notaion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Notaion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(Employee e)
        {
            if(ModelState.IsValid==true)
            {
                ViewData["ErrorMessage"] = "<script>alert('Data is Successfully Save')</script>";
                ModelState.Clear();
            }
            return View();
        }
       
    }
}