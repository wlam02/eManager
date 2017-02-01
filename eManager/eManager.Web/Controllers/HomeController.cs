using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;
using eManager.Web.Infastructure;

namespace eManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private IDepartmentDataSource _db;/* = new DepartmentDb();*/

        public HomeController(IDepartmentDataSource db) //make the home control know nothnig about department db sinc its privet. 
        {
            _db = db;
        }

        public ActionResult Index()
        {
            ViewBag.FullName = "Table";
            ViewBag.Messae = "This is the Index Page";
            var allDepartments = _db.Departments;

            return View(allDepartments);
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
    }
}