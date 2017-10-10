
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SignMeUpMVC.Models;

namespace SignMeUpMVC.Controllers
{
    public class ManagerController : Controller
    {
        private dbLocalTestEntities2 db = new dbLocalTestEntities2();

        // GET: Manager
        public ActionResult Index()
        {

        
            return View(db.tblOvertimes.ToList());

        }

        
        


        // GET: Manager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOvertime tblOvertime = db.tblOvertimes.Find(id);
            if (tblOvertime == null)
            {
                return HttpNotFound();
            }
            return View(tblOvertime);
        }

        // GET: Manager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OvertimeId,Location,DateTimeStart,DateTimeEnd,SignUpEnd,SelectedEmployeeId,IsDeleted")] tblOvertime tblOvertime)
        {
            if (ModelState.IsValid)
            {
                db.tblOvertimes.Add(tblOvertime);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblOvertime);
        }

        // GET: Manager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOvertime tblOvertime = db.tblOvertimes.Find(id);
            if (tblOvertime == null)
            {
                return HttpNotFound();
            }
            return View(tblOvertime);
        }

        // POST: Manager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OvertimeId,Location,DateTimeStart,DateTimeEnd,SignUpEnd,SelectedEmployeeId,IsDeleted")] tblOvertime tblOvertime)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblOvertime).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblOvertime);
        }

        // GET: Manager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOvertime tblOvertime = db.tblOvertimes.Find(id);
            if (tblOvertime == null)
            {
                return HttpNotFound();
            }
            return View(tblOvertime);
        }

        // POST: Manager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblOvertime tblOvertime = db.tblOvertimes.Find(id);
            db.tblOvertimes.Remove(tblOvertime);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
