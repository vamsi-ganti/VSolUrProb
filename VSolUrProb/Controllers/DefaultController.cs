using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VSolUrProb.Models;

namespace VSolUrProb.Controllers
{
    public class DefaultController : Controller
    {
        CompanyContext db = new CompanyContext();
        public ActionResult Index()
        { 
            db.DepartmentTable.ToList();
            db.EmployeeTable.ToList();
            return View();
        }
    }
}