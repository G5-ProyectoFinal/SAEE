﻿using SAEE_Web.Entities;
using SAEE_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAEE_Web.Controllers
{
    public class EnrolledController : Controller
    {
        EnrolledCoursesModel enrolledCoursesModel = new EnrolledCoursesModel();


        [HttpGet]
        public ActionResult EnrolledStudent()
        {
            ViewBag.SelectListCoursesAvailable = enrolledCoursesModel.SelectListCoursesAvailable();
            ViewBag.SelectListStudents = enrolledCoursesModel.SelectListStudents();
            return View();
        }


        [HttpPost]
        public ActionResult EnrolledStudent(EnrolledCoursesEnt enrolledCourses)
        {
            //user.activeUser = (int)Session["ActiveId"];//For action register

            ViewBag.SelectListCoursesAvailable = enrolledCoursesModel.SelectListCoursesAvailable();
            ViewBag.SelectListStudents = enrolledCoursesModel.SelectListStudents();

            var resp = enrolledCoursesModel.EnrolledStudent(enrolledCourses);

            if (resp == "OK")
            {
                ViewBag.BoxMessage = "Estudiante matriculado.";
                return View();
            }
            else
            {
                ViewBag.BoxMessage = "No se ha matriculado al estudiante.";
                ViewBag.SelectListCoursesAvailable = enrolledCoursesModel.SelectListCoursesAvailable();
                ViewBag.SelectListStudents = enrolledCoursesModel.SelectListStudents();
                return View();
            }
        }
    }
}