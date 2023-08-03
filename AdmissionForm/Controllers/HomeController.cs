using AdmissionForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using AdmissionForm.Models;

namespace AdmissionForm.Controllers
{
    public class HomeController : Controller
    {
        EmpContext em=new EmpContext();
        public ActionResult Index()
        {
            var data=em.empss.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Emp emp) 
        {
         if(ModelState.IsValid==true)
            {
                em.empss.Add(emp);
                int a = em.SaveChanges();


                if (a > 0)
                {
                    //ViewBag.InsertMessage = "<script>alert('Data Inserted')</script>";
                    //TempData["Succussc"] = "<script>alert('Data Inserted')</script>";
                    TempData["Succussc"] = "Data inserted!!";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data Not Inserted')</script>";
                }
            }
                           return View();
            
            
        
            
        }


    }
}