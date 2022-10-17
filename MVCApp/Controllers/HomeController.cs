﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // The View portion of the GET request. This method gets called in _Layout.cshtml on line 24 and pulls vars from EmployeeModel
        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Sign Up";

            return View();
            //Boomshut
        }
    }
}