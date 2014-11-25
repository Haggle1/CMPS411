using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDScanner.Controllers
{
    public class HomeController : Controller
    {

        private SchoolTrackerEntities1 db = new SchoolTrackerEntities1();

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

        public ActionResult TeacherView()
        {
            IDScanner.ViewModels.TeacherViewModel viewmodel = new IDScanner.ViewModels.TeacherViewModel();
            viewmodel.Attendance = db.Attendances; 
            viewmodel.Course = db.Courses;
            viewmodel.Faculty = db.Faculties;
            viewmodel.Schedule = db.Schedules;
            viewmodel.Student = db.Students;

            return View(viewmodel);
        }

    }
}