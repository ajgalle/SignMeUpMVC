using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignMeUpMVC.Models;

namespace SignMeUpMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            dbLocalTestEntities2 db = new dbLocalTestEntities2();

           
            List<OvertimeViewModel> AllOvertimeList = db.tblOvertimes.Where(x => x.IsDeleted != true).Select(x => new OvertimeViewModel { DateTimeEnd = x.DateTimeEnd, DateTimeStart = x.DateTimeStart, OvertimeId = x.OvertimeId, Location = x.Location, SignUpEnd = x.SignUpEnd, SelectedEmployeeId = x.SelectedEmployeeId }).ToList();
            
            ViewBag.AllOvertime = AllOvertimeList;


            return View();
        }

        public ActionResult AddOvertime()
        {

            return View();
        }

    }
}